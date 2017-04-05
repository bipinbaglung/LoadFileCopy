namespace FileCopy
{
    partial class FormFileCopy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileCopy));
            this.openLoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox_LoadFile = new System.Windows.Forms.TextBox();
            this.textBox_Destination = new System.Windows.Forms.TextBox();
            this.buttonShowDetail = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Copy = new System.Windows.Forms.Button();
            this.button_Browse = new System.Windows.Forms.Button();
            this.labelDeveloperInfo = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.button_ClearLog = new System.Windows.Forms.Button();
            this.backgroundWorker_DoCopy = new System.ComponentModel.BackgroundWorker();
            this.richTextBox_DetailLog = new System.Windows.Forms.RichTextBox();
            this.checkBoxMaintainFolderStructure = new System.Windows.Forms.CheckBox();
            this.radioButtonRename = new System.Windows.Forms.RadioButton();
            this.radioButtonSkip = new System.Windows.Forms.RadioButton();
            this.radioButtonReplace = new System.Windows.Forms.RadioButton();
            this.panelFileExistsOptions = new System.Windows.Forms.Panel();
            this.labelFileExists = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelFileExistsOptions.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // openLoadFileDialog
            // 
            this.openLoadFileDialog.FileName = "openLoadFileDialog";
            // 
            // textBox_LoadFile
            // 
            this.textBox_LoadFile.Location = new System.Drawing.Point(10, 6);
            this.textBox_LoadFile.Name = "textBox_LoadFile";
            this.textBox_LoadFile.Size = new System.Drawing.Size(436, 20);
            this.textBox_LoadFile.TabIndex = 12;
            this.textBox_LoadFile.Text = "Browse loadfile...";
            this.textBox_LoadFile.Click += new System.EventHandler(this.textBox_LoadFile_Click);
            this.textBox_LoadFile.Leave += new System.EventHandler(this.textBox_LoadFile_Leave);
            // 
            // textBox_Destination
            // 
            this.textBox_Destination.Location = new System.Drawing.Point(9, 37);
            this.textBox_Destination.Name = "textBox_Destination";
            this.textBox_Destination.Size = new System.Drawing.Size(361, 20);
            this.textBox_Destination.TabIndex = 13;
            this.textBox_Destination.Text = "Destination...";
            this.textBox_Destination.Click += new System.EventHandler(this.textBox_Destination_Click);
            this.textBox_Destination.Leave += new System.EventHandler(this.textBox_Destination_Leave);
            // 
            // buttonShowDetail
            // 
            this.buttonShowDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonShowDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonShowDetail.Location = new System.Drawing.Point(9, 96);
            this.buttonShowDetail.Name = "buttonShowDetail";
            this.buttonShowDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonShowDetail.TabIndex = 14;
            this.buttonShowDetail.Text = "Show Detail";
            this.buttonShowDetail.UseVisualStyleBackColor = true;
            this.buttonShowDetail.Click += new System.EventHandler(this.buttonShowDetail_Click);
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Close.Location = new System.Drawing.Point(452, 96);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 14;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Copy
            // 
            this.button_Copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Copy.Location = new System.Drawing.Point(452, 66);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(75, 23);
            this.button_Copy.TabIndex = 14;
            this.button_Copy.Text = "Copy";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // button_Browse
            // 
            this.button_Browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Browse.Location = new System.Drawing.Point(452, 5);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(75, 23);
            this.button_Browse.TabIndex = 14;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // labelDeveloperInfo
            // 
            this.labelDeveloperInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeveloperInfo.AutoSize = true;
            this.labelDeveloperInfo.Location = new System.Drawing.Point(192, 8);
            this.labelDeveloperInfo.Name = "labelDeveloperInfo";
            this.labelDeveloperInfo.Size = new System.Drawing.Size(138, 13);
            this.labelDeveloperInfo.TabIndex = 15;
            this.labelDeveloperInfo.Text = "Developed by BipinBaglung";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(90, 101);
            this.labelMessage.MaximumSize = new System.Drawing.Size(360, 26);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 15;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_ClearLog
            // 
            this.button_ClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ClearLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_ClearLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_ClearLog.Location = new System.Drawing.Point(7, 3);
            this.button_ClearLog.Name = "button_ClearLog";
            this.button_ClearLog.Size = new System.Drawing.Size(75, 23);
            this.button_ClearLog.TabIndex = 17;
            this.button_ClearLog.Text = "Clear Log";
            this.button_ClearLog.UseVisualStyleBackColor = true;
            this.button_ClearLog.Visible = false;
            this.button_ClearLog.Click += new System.EventHandler(this.button_ClearLog_Click);
            // 
            // backgroundWorker_DoCopy
            // 
            this.backgroundWorker_DoCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoCopy_DoWork);
            this.backgroundWorker_DoCopy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_DoCopy_RunWorkerCompleted);
            // 
            // richTextBox_DetailLog
            // 
            this.richTextBox_DetailLog.BackColor = System.Drawing.Color.Snow;
            this.richTextBox_DetailLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_DetailLog.Location = new System.Drawing.Point(5, 123);
            this.richTextBox_DetailLog.Name = "richTextBox_DetailLog";
            this.richTextBox_DetailLog.ReadOnly = true;
            this.richTextBox_DetailLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_DetailLog.Size = new System.Drawing.Size(532, 232);
            this.richTextBox_DetailLog.TabIndex = 18;
            this.richTextBox_DetailLog.Text = "";
            // 
            // checkBoxMaintainFolderStructure
            // 
            this.checkBoxMaintainFolderStructure.AutoSize = true;
            this.checkBoxMaintainFolderStructure.Location = new System.Drawing.Point(388, 39);
            this.checkBoxMaintainFolderStructure.Name = "checkBoxMaintainFolderStructure";
            this.checkBoxMaintainFolderStructure.Size = new System.Drawing.Size(139, 17);
            this.checkBoxMaintainFolderStructure.TabIndex = 19;
            this.checkBoxMaintainFolderStructure.Text = "Maintain folder structure";
            this.checkBoxMaintainFolderStructure.UseVisualStyleBackColor = true;
            // 
            // radioButtonRename
            // 
            this.radioButtonRename.AutoSize = true;
            this.radioButtonRename.Location = new System.Drawing.Point(77, 7);
            this.radioButtonRename.Name = "radioButtonRename";
            this.radioButtonRename.Size = new System.Drawing.Size(65, 17);
            this.radioButtonRename.TabIndex = 21;
            this.radioButtonRename.Text = "Rename";
            this.radioButtonRename.UseVisualStyleBackColor = true;
            // 
            // radioButtonSkip
            // 
            this.radioButtonSkip.AutoSize = true;
            this.radioButtonSkip.Checked = true;
            this.radioButtonSkip.Location = new System.Drawing.Point(148, 7);
            this.radioButtonSkip.Name = "radioButtonSkip";
            this.radioButtonSkip.Size = new System.Drawing.Size(46, 17);
            this.radioButtonSkip.TabIndex = 22;
            this.radioButtonSkip.TabStop = true;
            this.radioButtonSkip.Text = "Skip";
            this.radioButtonSkip.UseVisualStyleBackColor = true;
            // 
            // radioButtonReplace
            // 
            this.radioButtonReplace.AutoSize = true;
            this.radioButtonReplace.Location = new System.Drawing.Point(6, 7);
            this.radioButtonReplace.Name = "radioButtonReplace";
            this.radioButtonReplace.Size = new System.Drawing.Size(65, 17);
            this.radioButtonReplace.TabIndex = 23;
            this.radioButtonReplace.Text = "Replace";
            this.radioButtonReplace.UseVisualStyleBackColor = true;
            // 
            // panelFileExistsOptions
            // 
            this.panelFileExistsOptions.Controls.Add(this.radioButtonReplace);
            this.panelFileExistsOptions.Controls.Add(this.radioButtonSkip);
            this.panelFileExistsOptions.Controls.Add(this.radioButtonRename);
            this.panelFileExistsOptions.Location = new System.Drawing.Point(115, 63);
            this.panelFileExistsOptions.Name = "panelFileExistsOptions";
            this.panelFileExistsOptions.Size = new System.Drawing.Size(200, 32);
            this.panelFileExistsOptions.TabIndex = 25;
            // 
            // labelFileExists
            // 
            this.labelFileExists.AutoSize = true;
            this.labelFileExists.Location = new System.Drawing.Point(11, 70);
            this.labelFileExists.Name = "labelFileExists";
            this.labelFileExists.Size = new System.Drawing.Size(98, 13);
            this.labelFileExists.TabIndex = 24;
            this.labelFileExists.Text = "File already exists : ";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.button_ClearLog);
            this.panelFooter.Controls.Add(this.labelDeveloperInfo);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(5, 355);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(532, 29);
            this.panelFooter.TabIndex = 26;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.textBox_LoadFile);
            this.panelBody.Controls.Add(this.textBox_Destination);
            this.panelBody.Controls.Add(this.buttonShowDetail);
            this.panelBody.Controls.Add(this.panelFileExistsOptions);
            this.panelBody.Controls.Add(this.button_Close);
            this.panelBody.Controls.Add(this.checkBoxMaintainFolderStructure);
            this.panelBody.Controls.Add(this.button_Copy);
            this.panelBody.Controls.Add(this.button_Browse);
            this.panelBody.Controls.Add(this.labelMessage);
            this.panelBody.Controls.Add(this.labelFileExists);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBody.Location = new System.Drawing.Point(5, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(532, 123);
            this.panelBody.TabIndex = 27;
            // 
            // FormFileCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(542, 384);
            this.Controls.Add(this.richTextBox_DetailLog);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelFooter);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFileCopy";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Copy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFileCopy_FormClosing);
            this.panelFileExistsOptions.ResumeLayout(false);
            this.panelFileExistsOptions.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openLoadFileDialog;
        private System.Windows.Forms.TextBox textBox_LoadFile;
        private System.Windows.Forms.TextBox textBox_Destination;
        private System.Windows.Forms.Button buttonShowDetail;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.Label labelDeveloperInfo;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button button_ClearLog;
        private System.ComponentModel.BackgroundWorker backgroundWorker_DoCopy;
        private System.Windows.Forms.RichTextBox richTextBox_DetailLog;
        private System.Windows.Forms.CheckBox checkBoxMaintainFolderStructure;
        private System.Windows.Forms.RadioButton radioButtonRename;
        private System.Windows.Forms.RadioButton radioButtonSkip;
        private System.Windows.Forms.RadioButton radioButtonReplace;
        private System.Windows.Forms.Panel panelFileExistsOptions;
        private System.Windows.Forms.Label labelFileExists;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBody;
    }
}

