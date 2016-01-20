namespace BackDown
{
    partial class JournalAndRecoverForm
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
            this.findBackupsGroupBox = new System.Windows.Forms.GroupBox();
            this.backupsGroupBox = new System.Windows.Forms.GroupBox();
            this.cliToolNameTextBox = new System.Windows.Forms.TextBox();
            this.journalButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.targetLabel = new System.Windows.Forms.Label();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.toolLabel = new System.Windows.Forms.Label();
            this.restoreFolderTextBox = new System.Windows.Forms.TextBox();
            this.restoreFolderLabel = new System.Windows.Forms.Label();
            this.backupsListBox = new System.Windows.Forms.ListBox();
            this.findByFolderGroupBox = new System.Windows.Forms.GroupBox();
            this.findByTargetButton = new System.Windows.Forms.Button();
            this.findByTargetBrowseButton = new System.Windows.Forms.Button();
            this.findByTargetTextBox = new System.Windows.Forms.TextBox();
            this.findByTargetLabel = new System.Windows.Forms.Label();
            this.findBySettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.findByNameComboBox = new System.Windows.Forms.ComboBox();
            this.findByNameButton = new System.Windows.Forms.Button();
            this.findByNameLabel = new System.Windows.Forms.Label();
            this.targetFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.restoreFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.findBackupsGroupBox.SuspendLayout();
            this.backupsGroupBox.SuspendLayout();
            this.findByFolderGroupBox.SuspendLayout();
            this.findBySettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // findBackupsGroupBox
            // 
            this.findBackupsGroupBox.Controls.Add(this.backupsGroupBox);
            this.findBackupsGroupBox.Controls.Add(this.findByFolderGroupBox);
            this.findBackupsGroupBox.Controls.Add(this.findBySettingsGroupBox);
            this.findBackupsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.findBackupsGroupBox.Name = "findBackupsGroupBox";
            this.findBackupsGroupBox.Size = new System.Drawing.Size(840, 439);
            this.findBackupsGroupBox.TabIndex = 0;
            this.findBackupsGroupBox.TabStop = false;
            this.findBackupsGroupBox.Text = "Biztonsági mentések keresése";
            // 
            // backupsGroupBox
            // 
            this.backupsGroupBox.Controls.Add(this.cliToolNameTextBox);
            this.backupsGroupBox.Controls.Add(this.journalButton);
            this.backupsGroupBox.Controls.Add(this.restoreButton);
            this.backupsGroupBox.Controls.Add(this.targetLabel);
            this.backupsGroupBox.Controls.Add(this.targetTextBox);
            this.backupsGroupBox.Controls.Add(this.sourceLabel);
            this.backupsGroupBox.Controls.Add(this.sourceTextBox);
            this.backupsGroupBox.Controls.Add(this.toolLabel);
            this.backupsGroupBox.Controls.Add(this.restoreFolderTextBox);
            this.backupsGroupBox.Controls.Add(this.restoreFolderLabel);
            this.backupsGroupBox.Controls.Add(this.backupsListBox);
            this.backupsGroupBox.Location = new System.Drawing.Point(6, 143);
            this.backupsGroupBox.Name = "backupsGroupBox";
            this.backupsGroupBox.Size = new System.Drawing.Size(828, 290);
            this.backupsGroupBox.TabIndex = 2;
            this.backupsGroupBox.TabStop = false;
            this.backupsGroupBox.Text = "Találatok";
            // 
            // cliToolNameTextBox
            // 
            this.cliToolNameTextBox.Location = new System.Drawing.Point(496, 19);
            this.cliToolNameTextBox.Name = "cliToolNameTextBox";
            this.cliToolNameTextBox.ReadOnly = true;
            this.cliToolNameTextBox.Size = new System.Drawing.Size(308, 20);
            this.cliToolNameTextBox.TabIndex = 1;
            // 
            // journalButton
            // 
            this.journalButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.journalButton.Location = new System.Drawing.Point(496, 121);
            this.journalButton.Name = "journalButton";
            this.journalButton.Size = new System.Drawing.Size(111, 30);
            this.journalButton.TabIndex = 5;
            this.journalButton.Text = "Napló";
            this.journalButton.UseVisualStyleBackColor = false;
            this.journalButton.Click += new System.EventHandler(this.journalButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.LightCoral;
            this.restoreButton.Location = new System.Drawing.Point(496, 217);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(111, 30);
            this.restoreButton.TabIndex = 7;
            this.restoreButton.Text = "Helyreállít";
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(433, 98);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(57, 13);
            this.targetLabel.TabIndex = 14;
            this.targetLabel.Text = "Cél mappa";
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(496, 95);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.ReadOnly = true;
            this.targetTextBox.Size = new System.Drawing.Size(308, 20);
            this.targetTextBox.TabIndex = 4;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(419, 72);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(71, 13);
            this.sourceLabel.TabIndex = 12;
            this.sourceLabel.Text = "Forrás mappa";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(496, 69);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ReadOnly = true;
            this.sourceTextBox.Size = new System.Drawing.Size(308, 20);
            this.sourceTextBox.TabIndex = 3;
            // 
            // toolLabel
            // 
            this.toolLabel.AutoSize = true;
            this.toolLabel.Location = new System.Drawing.Point(392, 22);
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(98, 13);
            this.toolLabel.TabIndex = 9;
            this.toolLabel.Text = "Parancssori eszköz";
            // 
            // restoreFolderTextBox
            // 
            this.restoreFolderTextBox.Location = new System.Drawing.Point(496, 191);
            this.restoreFolderTextBox.Name = "restoreFolderTextBox";
            this.restoreFolderTextBox.Size = new System.Drawing.Size(308, 20);
            this.restoreFolderTextBox.TabIndex = 6;
            this.restoreFolderTextBox.Enter += new System.EventHandler(this.restoreFolderTextBox_Enter);
            // 
            // restoreFolderLabel
            // 
            this.restoreFolderLabel.AutoSize = true;
            this.restoreFolderLabel.Location = new System.Drawing.Point(388, 194);
            this.restoreFolderLabel.Name = "restoreFolderLabel";
            this.restoreFolderLabel.Size = new System.Drawing.Size(102, 13);
            this.restoreFolderLabel.TabIndex = 5;
            this.restoreFolderLabel.Text = "Helyreállítási mappa";
            // 
            // backupsListBox
            // 
            this.backupsListBox.FormattingEnabled = true;
            this.backupsListBox.Location = new System.Drawing.Point(6, 19);
            this.backupsListBox.Name = "backupsListBox";
            this.backupsListBox.Size = new System.Drawing.Size(359, 264);
            this.backupsListBox.TabIndex = 0;
            this.backupsListBox.SelectedIndexChanged += new System.EventHandler(this.backupsListBox_SelectedIndexChanged);
            // 
            // findByFolderGroupBox
            // 
            this.findByFolderGroupBox.Controls.Add(this.findByTargetButton);
            this.findByFolderGroupBox.Controls.Add(this.findByTargetBrowseButton);
            this.findByFolderGroupBox.Controls.Add(this.findByTargetTextBox);
            this.findByFolderGroupBox.Controls.Add(this.findByTargetLabel);
            this.findByFolderGroupBox.Location = new System.Drawing.Point(6, 19);
            this.findByFolderGroupBox.Name = "findByFolderGroupBox";
            this.findByFolderGroupBox.Size = new System.Drawing.Size(540, 57);
            this.findByFolderGroupBox.TabIndex = 0;
            this.findByFolderGroupBox.TabStop = false;
            this.findByFolderGroupBox.Text = "Mappa megadásával";
            // 
            // findByTargetButton
            // 
            this.findByTargetButton.Location = new System.Drawing.Point(452, 20);
            this.findByTargetButton.Name = "findByTargetButton";
            this.findByTargetButton.Size = new System.Drawing.Size(75, 23);
            this.findByTargetButton.TabIndex = 2;
            this.findByTargetButton.Text = "Keres";
            this.findByTargetButton.UseVisualStyleBackColor = true;
            this.findByTargetButton.Click += new System.EventHandler(this.findByTargetButton_Click);
            // 
            // findByTargetBrowseButton
            // 
            this.findByTargetBrowseButton.Location = new System.Drawing.Point(371, 20);
            this.findByTargetBrowseButton.Name = "findByTargetBrowseButton";
            this.findByTargetBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.findByTargetBrowseButton.TabIndex = 1;
            this.findByTargetBrowseButton.Text = "Tallóz ...";
            this.findByTargetBrowseButton.UseVisualStyleBackColor = true;
            this.findByTargetBrowseButton.Click += new System.EventHandler(this.findByTargetBrowseButton_Click);
            // 
            // findByTargetTextBox
            // 
            this.findByTargetTextBox.Location = new System.Drawing.Point(105, 22);
            this.findByTargetTextBox.Name = "findByTargetTextBox";
            this.findByTargetTextBox.Size = new System.Drawing.Size(260, 20);
            this.findByTargetTextBox.TabIndex = 0;
            // 
            // findByTargetLabel
            // 
            this.findByTargetLabel.AutoSize = true;
            this.findByTargetLabel.Location = new System.Drawing.Point(42, 25);
            this.findByTargetLabel.Name = "findByTargetLabel";
            this.findByTargetLabel.Size = new System.Drawing.Size(57, 13);
            this.findByTargetLabel.TabIndex = 0;
            this.findByTargetLabel.Text = "Cél mappa";
            // 
            // findBySettingsGroupBox
            // 
            this.findBySettingsGroupBox.Controls.Add(this.findByNameComboBox);
            this.findBySettingsGroupBox.Controls.Add(this.findByNameButton);
            this.findBySettingsGroupBox.Controls.Add(this.findByNameLabel);
            this.findBySettingsGroupBox.Location = new System.Drawing.Point(6, 82);
            this.findBySettingsGroupBox.Name = "findBySettingsGroupBox";
            this.findBySettingsGroupBox.Size = new System.Drawing.Size(540, 55);
            this.findBySettingsGroupBox.TabIndex = 1;
            this.findBySettingsGroupBox.TabStop = false;
            this.findBySettingsGroupBox.Text = "Tárolt mentési beálítás alapján";
            // 
            // findByNameComboBox
            // 
            this.findByNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.findByNameComboBox.FormattingEnabled = true;
            this.findByNameComboBox.Location = new System.Drawing.Point(105, 19);
            this.findByNameComboBox.Name = "findByNameComboBox";
            this.findByNameComboBox.Size = new System.Drawing.Size(260, 21);
            this.findByNameComboBox.TabIndex = 0;
            // 
            // findByNameButton
            // 
            this.findByNameButton.Location = new System.Drawing.Point(371, 18);
            this.findByNameButton.Name = "findByNameButton";
            this.findByNameButton.Size = new System.Drawing.Size(75, 23);
            this.findByNameButton.TabIndex = 1;
            this.findByNameButton.Text = "Keres";
            this.findByNameButton.UseVisualStyleBackColor = true;
            this.findByNameButton.Click += new System.EventHandler(this.findByNameButton_Click);
            // 
            // findByNameLabel
            // 
            this.findByNameLabel.AutoSize = true;
            this.findByNameLabel.Location = new System.Drawing.Point(72, 22);
            this.findByNameLabel.Name = "findByNameLabel";
            this.findByNameLabel.Size = new System.Drawing.Size(27, 13);
            this.findByNameLabel.TabIndex = 2;
            this.findByNameLabel.Text = "Név";
            // 
            // JournalAndRecoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 463);
            this.Controls.Add(this.findBackupsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JournalAndRecoverForm";
            this.Text = "Napló és Helyreállítás";
            this.findBackupsGroupBox.ResumeLayout(false);
            this.backupsGroupBox.ResumeLayout(false);
            this.backupsGroupBox.PerformLayout();
            this.findByFolderGroupBox.ResumeLayout(false);
            this.findByFolderGroupBox.PerformLayout();
            this.findBySettingsGroupBox.ResumeLayout(false);
            this.findBySettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox findBackupsGroupBox;
        private System.Windows.Forms.GroupBox findByFolderGroupBox;
        private System.Windows.Forms.Button findByTargetBrowseButton;
        private System.Windows.Forms.TextBox findByTargetTextBox;
        private System.Windows.Forms.Label findByTargetLabel;
        private System.Windows.Forms.GroupBox findBySettingsGroupBox;
        private System.Windows.Forms.Button findByNameButton;
        private System.Windows.Forms.Label findByNameLabel;
        private System.Windows.Forms.ComboBox findByNameComboBox;
        private System.Windows.Forms.Button findByTargetButton;
        private System.Windows.Forms.GroupBox backupsGroupBox;
        private System.Windows.Forms.ListBox backupsListBox;
        private System.Windows.Forms.TextBox restoreFolderTextBox;
        private System.Windows.Forms.Label restoreFolderLabel;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label toolLabel;
        private System.Windows.Forms.Button journalButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.TextBox cliToolNameTextBox;
        private System.Windows.Forms.FolderBrowserDialog targetFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog restoreFolderBrowserDialog;
    }
}