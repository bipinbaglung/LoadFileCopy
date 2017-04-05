using System;
using System.IO;
using System.Windows.Forms;

namespace FileCopy
{
    public partial class FormFileCopy : Form
    {
        private const int HIDDEN_DETAIL_HEIGHT = 150;
        private const int SHOWN_DETAIL_HEIGHT = 360;
        private const int FORM_WIDTH = 550;

        private string copy_location = string.Empty;
        private string loadfilename = string.Empty;
        private bool doReplace = false;
        private bool doRename = false;
        private bool doSkip = true;
        private bool maintainFolderStructure = false;

        private enum LogMessageType { NORMAL, WARNING, ERROR }

        public FormFileCopy()
        {
            InitializeComponent();
            SetDetailVisibility(false);
        }

        private void backgroundWorker_DoCopy_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ToggleButtons(false);
            bool successful = false;
            successful = StartFileCopy();
            if (successful)
            {
                setInfoMessage("Completed successfully.");
            }
            else
            {
                setInfoMessage("Completed with error.");
            }

        }

        private bool StartFileCopy()
        {

            bool isClean = true;
            if (!Directory.Exists(copy_location))
            {
                LogDetailMessage("Destination does not exist.", LogMessageType.WARNING);
                LogDetailMessage("Creating destination directory -  " + copy_location, LogMessageType.NORMAL);
                try
                {
                    Directory.CreateDirectory(copy_location);
                    LogDetailMessage("Destination directory created.", LogMessageType.NORMAL);
                }
                catch (Exception ex)
                {
                    LogDetailMessage(ex.Message, LogMessageType.ERROR);
                    isClean = false;
                }
            }

            if (isClean)
            {
                LogDetailMessage("Copy started...", LogMessageType.NORMAL);
                using (StreamReader reader = new StreamReader(loadfilename))
                {
                    while (!reader.EndOfStream)
                    {
                        string access_path = reader.ReadLine().Trim('"').Trim();

                        if (access_path.Length > 0)
                        {
                            try
                            {
                                if (!System.IO.File.Exists(access_path))
                                {
                                    LogDetailMessage("Source file \"" + access_path + "\" does not exists.", LogMessageType.ERROR);
                                    continue;
                                }
                                string destination_path = string.Empty;
                                string filename = Path.GetFileName(access_path);

                                if (maintainFolderStructure)
                                {
                                    string rootPath = Path.GetPathRoot(access_path);
                                    destination_path = System.IO.Path.Combine(copy_location, access_path.Remove(0, rootPath.Length).TrimStart('\\'));
                                    Directory.CreateDirectory(Path.GetDirectoryName(destination_path));
                                }
                                else
                                {
                                    destination_path = System.IO.Path.Combine(copy_location, filename);
                                }

                                setInfoMessage(access_path + " => " + destination_path);

                                if (System.IO.File.Exists(destination_path))
                                {
                                    if (doSkip)
                                    {
                                        LogDetailMessage("Skipped file \"" + destination_path + "\"", LogMessageType.WARNING);
                                        continue;
                                    }
                                    else if (doRename)
                                    {
                                        string fileName = Path.GetFileNameWithoutExtension(destination_path);
                                        string fileExtension = Path.GetExtension(destination_path);

                                        int c = 1;
                                        while (System.IO.File.Exists(destination_path))
                                        {
                                            string computedPath = System.IO.Path.Combine(copy_location, fileName + " (" + c.ToString() + ")." + fileExtension);
                                            if (!System.IO.File.Exists(computedPath))
                                            {
                                                destination_path = computedPath;
                                                break;
                                            }
                                            c++;
                                            if (c > Int16.MaxValue)
                                                break;
                                        }
                                    }
                                }
                                System.IO.File.Copy(access_path, destination_path, doReplace);
                                LogDetailMessage("Copied file from \"" + access_path + "\" to \"" + destination_path + "\" successfully.", LogMessageType.NORMAL);
                            }
                            catch (Exception ex)
                            {
                                LogDetailMessage(ex.Message, LogMessageType.ERROR);
                                isClean = false;
                            }
                        }
                    }
                }
                LogDetailMessage("Copy completed.", LogMessageType.NORMAL);
            }
            return isClean;
        }

        private void LogDetailMessage(string message, LogMessageType error)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, LogMessageType>(LogDetailMessage), message, error);
                return;
            }
            System.Drawing.Color textColor = System.Drawing.Color.Black;

            if (error == LogMessageType.ERROR)
                textColor = System.Drawing.Color.Red;
            else if (error == LogMessageType.WARNING)
                textColor = System.Drawing.Color.Chocolate;

            richTextBox_DetailLog.AppendText(">> ");
            richTextBox_DetailLog.SelectionStart = richTextBox_DetailLog.TextLength;
            richTextBox_DetailLog.SelectionLength = 0;
            richTextBox_DetailLog.SelectionColor = textColor;
            richTextBox_DetailLog.AppendText(message + Environment.NewLine);
            richTextBox_DetailLog.SelectionColor = richTextBox_DetailLog.ForeColor;
        }

        private void ToggleButtons(bool isEnabled)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(ToggleButtons), isEnabled);
                return;
            }

            button_Browse.Enabled = isEnabled;
            button_Copy.Enabled = isEnabled;
            button_Close.Text = isEnabled ? "Close" : "Cancel";
        }

        private void setInfoMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(setInfoMessage), message);
                return;
            }
            labelMessage.Text = message;

        }

        private void textBox_LoadFile_Click(object sender, EventArgs e)
        {
            if (textBox_LoadFile.Text.ToUpper() == "BROWSE LOADFILE...")
                textBox_LoadFile.Text = string.Empty;
        }

        private void textBox_LoadFile_Leave(object sender, EventArgs e)
        {
            if (textBox_LoadFile.Text == string.Empty)
                textBox_LoadFile.Text = "Browse loadfile...";
        }

        private void textBox_Destination_Click(object sender, EventArgs e)
        {
            if (textBox_Destination.Text.ToUpper() == "DESTINATION...")
                textBox_Destination.Text = string.Empty;
        }

        private void textBox_Destination_Leave(object sender, EventArgs e)
        {
            if (textBox_Destination.Text == string.Empty)
                textBox_Destination.Text = "Destination...";
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            openLoadFileDialog.Title = "Select file...";
            openLoadFileDialog.Filter = "(*.txt)|*.txt";

            openLoadFileDialog.FileName = string.Empty;
            if (openLoadFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_LoadFile.Text = (openLoadFileDialog.FileName.Trim().Length > 0) ? openLoadFileDialog.FileName : "";
                textBox_Destination.Text = Path.GetDirectoryName(textBox_LoadFile.Text);
            }
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            loadfilename = textBox_LoadFile.Text;
            copy_location = textBox_Destination.Text;
            doReplace = radioButtonReplace.Checked;
            doRename = radioButtonRename.Checked;
            doSkip = radioButtonSkip.Checked;
            maintainFolderStructure = checkBoxMaintainFolderStructure.Checked;

            if (loadfilename.Length != 0 && copy_location.Length != 0 && loadfilename.ToUpper() != "BROWSE LOADFILE..." && copy_location.ToUpper() != "DESTINATION...")
                backgroundWorker_DoCopy.RunWorkerAsync();
            else
            {
                MessageBox.Show("Please check and enter valid value. ", "Invalid Input");
                return;
            }

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            if (button_Close.Text.Equals("Close", StringComparison.CurrentCultureIgnoreCase))
                this.Close();
            else
                backgroundWorker_DoCopy.CancelAsync();
        }

        private void buttonShowDetail_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.ToUpper() == "SHOW DETAIL")
            {
                SetDetailVisibility(true);
            }
            else if (btn.Text.ToUpper() == "HIDE DETAIL")
            {
                SetDetailVisibility(false);
            }
        }

        private void SetDetailVisibility(bool visibile)
        {
            richTextBox_DetailLog.Visible = visibile;
            this.ClientSize = new System.Drawing.Size(FORM_WIDTH, visibile ? SHOWN_DETAIL_HEIGHT : HIDDEN_DETAIL_HEIGHT);
            buttonShowDetail.Text = visibile ? "Hide Detail" : "Show Detail";
            button_ClearLog.Visible = visibile;
        }

        private void button_ClearLog_Click(object sender, EventArgs e)
        {
            richTextBox_DetailLog.Clear();
        }

        private void FormFileCopy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker_DoCopy.IsBusy)
                e.Cancel = true;
        }

        private void backgroundWorker_DoCopy_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ToggleButtons(true);
        }
    }
}
