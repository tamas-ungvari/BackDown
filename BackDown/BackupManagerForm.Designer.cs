namespace BackDown
{
    partial class BackupManagerForm
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
            this.quickBackupGroupBox = new System.Windows.Forms.GroupBox();
            this.incrementalCheckBox = new System.Windows.Forms.CheckBox();
            this.startBackupButton = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.saveBackupSettingsButton = new System.Windows.Forms.Button();
            this.saveAsNameTextBox = new System.Windows.Forms.TextBox();
            this.saveAsNameLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.browseTargetButton = new System.Windows.Forms.Button();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.browseSourceButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.toolLabel = new System.Windows.Forms.Label();
            this.cliToolComboBox = new System.Windows.Forms.ComboBox();
            this.sourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.targetFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backupSettingsPicker = new BackDown.BackupSettingsPicker();
            this.newBackupSettingsButton = new System.Windows.Forms.Button();
            this.deleteBackupSettingsButton = new System.Windows.Forms.Button();
            this.quickBackupGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // quickBackupGroupBox
            // 
            this.quickBackupGroupBox.Controls.Add(this.saveBackupSettingsButton);
            this.quickBackupGroupBox.Controls.Add(this.saveAsNameTextBox);
            this.quickBackupGroupBox.Controls.Add(this.saveAsNameLabel);
            this.quickBackupGroupBox.Controls.Add(this.newBackupSettingsButton);
            this.quickBackupGroupBox.Controls.Add(this.incrementalCheckBox);
            this.quickBackupGroupBox.Controls.Add(this.startBackupButton);
            this.quickBackupGroupBox.Controls.Add(this.noteTextBox);
            this.quickBackupGroupBox.Controls.Add(this.targetLabel);
            this.quickBackupGroupBox.Controls.Add(this.label4);
            this.quickBackupGroupBox.Controls.Add(this.browseTargetButton);
            this.quickBackupGroupBox.Controls.Add(this.targetTextBox);
            this.quickBackupGroupBox.Controls.Add(this.sourceLabel);
            this.quickBackupGroupBox.Controls.Add(this.browseSourceButton);
            this.quickBackupGroupBox.Controls.Add(this.sourceTextBox);
            this.quickBackupGroupBox.Controls.Add(this.toolLabel);
            this.quickBackupGroupBox.Controls.Add(this.cliToolComboBox);
            this.quickBackupGroupBox.Location = new System.Drawing.Point(85, 12);
            this.quickBackupGroupBox.Name = "quickBackupGroupBox";
            this.quickBackupGroupBox.Size = new System.Drawing.Size(587, 216);
            this.quickBackupGroupBox.TabIndex = 0;
            this.quickBackupGroupBox.TabStop = false;
            this.quickBackupGroupBox.Text = "Mentés";
            // 
            // incrementalCheckBox
            // 
            this.incrementalCheckBox.AutoSize = true;
            this.incrementalCheckBox.Location = new System.Drawing.Point(137, 72);
            this.incrementalCheckBox.Name = "incrementalCheckBox";
            this.incrementalCheckBox.Size = new System.Drawing.Size(125, 17);
            this.incrementalCheckBox.TabIndex = 2;
            this.incrementalCheckBox.Text = "Inkrementális mentés";
            this.incrementalCheckBox.UseVisualStyleBackColor = true;
            this.incrementalCheckBox.Click += new System.EventHandler(this.incrementalCheckBox_Click);
            // 
            // startBackupButton
            // 
            this.startBackupButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.startBackupButton.Location = new System.Drawing.Point(137, 173);
            this.startBackupButton.Name = "startBackupButton";
            this.startBackupButton.Size = new System.Drawing.Size(130, 30);
            this.startBackupButton.TabIndex = 10;
            this.startBackupButton.Text = "Mentés indítása";
            this.startBackupButton.UseVisualStyleBackColor = false;
            this.startBackupButton.Click += new System.EventHandler(this.startBackupButton_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(137, 147);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(308, 20);
            this.noteTextBox.TabIndex = 8;
            // 
            // saveBackupSettingsButton
            // 
            this.saveBackupSettingsButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.saveBackupSettingsButton.Location = new System.Drawing.Point(315, 173);
            this.saveBackupSettingsButton.Name = "saveBackupSettingsButton";
            this.saveBackupSettingsButton.Size = new System.Drawing.Size(130, 30);
            this.saveBackupSettingsButton.TabIndex = 12;
            this.saveBackupSettingsButton.Text = "Beállítás tárolása";
            this.saveBackupSettingsButton.UseVisualStyleBackColor = false;
            this.saveBackupSettingsButton.Click += new System.EventHandler(this.saveBackupSettingsButton_Click);
            // 
            // saveAsNameTextBox
            // 
            this.saveAsNameTextBox.Location = new System.Drawing.Point(137, 19);
            this.saveAsNameTextBox.Name = "saveAsNameTextBox";
            this.saveAsNameTextBox.Size = new System.Drawing.Size(308, 20);
            this.saveAsNameTextBox.TabIndex = 10;
            this.saveAsNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.saveAsNameTextBox_KeyPress);
            // 
            // saveAsNameLabel
            // 
            this.saveAsNameLabel.AutoSize = true;
            this.saveAsNameLabel.Location = new System.Drawing.Point(104, 22);
            this.saveAsNameLabel.Name = "saveAsNameLabel";
            this.saveAsNameLabel.Size = new System.Drawing.Size(27, 13);
            this.saveAsNameLabel.TabIndex = 11;
            this.saveAsNameLabel.Text = "Név";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(74, 124);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(57, 13);
            this.targetLabel.TabIndex = 7;
            this.targetLabel.Text = "Cél mappa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Megjegyzés (opcionális)";
            // 
            // browseTargetButton
            // 
            this.browseTargetButton.Location = new System.Drawing.Point(451, 119);
            this.browseTargetButton.Name = "browseTargetButton";
            this.browseTargetButton.Size = new System.Drawing.Size(124, 23);
            this.browseTargetButton.TabIndex = 6;
            this.browseTargetButton.Text = "Tallóz ...";
            this.browseTargetButton.UseVisualStyleBackColor = true;
            this.browseTargetButton.Click += new System.EventHandler(this.browseTargetButton_Click);
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(137, 121);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(308, 20);
            this.targetTextBox.TabIndex = 5;
            this.targetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.targetTextBox_KeyPress);
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(60, 98);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(71, 13);
            this.sourceLabel.TabIndex = 4;
            this.sourceLabel.Text = "Forrás mappa";
            // 
            // browseSourceButton
            // 
            this.browseSourceButton.Location = new System.Drawing.Point(451, 93);
            this.browseSourceButton.Name = "browseSourceButton";
            this.browseSourceButton.Size = new System.Drawing.Size(124, 23);
            this.browseSourceButton.TabIndex = 3;
            this.browseSourceButton.Text = "Tallóz ...";
            this.browseSourceButton.UseVisualStyleBackColor = true;
            this.browseSourceButton.Click += new System.EventHandler(this.browseSourceButton_Click);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(137, 95);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(308, 20);
            this.sourceTextBox.TabIndex = 2;
            this.sourceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sourceTextBox_KeyPress);
            // 
            // toolLabel
            // 
            this.toolLabel.AutoSize = true;
            this.toolLabel.Location = new System.Drawing.Point(33, 48);
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(98, 13);
            this.toolLabel.TabIndex = 1;
            this.toolLabel.Text = "Parancssori eszköz";
            // 
            // cliToolComboBox
            // 
            this.cliToolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cliToolComboBox.FormattingEnabled = true;
            this.cliToolComboBox.Location = new System.Drawing.Point(137, 45);
            this.cliToolComboBox.Name = "cliToolComboBox";
            this.cliToolComboBox.Size = new System.Drawing.Size(308, 21);
            this.cliToolComboBox.TabIndex = 0;
            this.cliToolComboBox.SelectedIndexChanged += new System.EventHandler(this.cliToolComboBox_SelectedIndexChanged);
            // 
            // sourceFolderBrowserDialog
            // 
            this.sourceFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backupSettingsPicker);
            this.groupBox2.Controls.Add(this.deleteBackupSettingsButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tárolt beállítások";
            // 
            // backupSettingsPicker
            // 
            this.backupSettingsPicker.Location = new System.Drawing.Point(6, 48);
            this.backupSettingsPicker.Name = "backupSettingsPicker";
            this.backupSettingsPicker.Size = new System.Drawing.Size(735, 230);
            this.backupSettingsPicker.TabIndex = 4;
            // 
            // newBackupSettingsButton
            // 
            this.newBackupSettingsButton.Location = new System.Drawing.Point(451, 17);
            this.newBackupSettingsButton.Name = "newBackupSettingsButton";
            this.newBackupSettingsButton.Size = new System.Drawing.Size(124, 23);
            this.newBackupSettingsButton.TabIndex = 3;
            this.newBackupSettingsButton.Text = "Új beállítás";
            this.newBackupSettingsButton.UseVisualStyleBackColor = true;
            this.newBackupSettingsButton.Click += new System.EventHandler(this.newBackupSettingsButton_Click);
            // 
            // deleteBackupSettingsButton
            // 
            this.deleteBackupSettingsButton.Enabled = false;
            this.deleteBackupSettingsButton.Location = new System.Drawing.Point(6, 19);
            this.deleteBackupSettingsButton.Name = "deleteBackupSettingsButton";
            this.deleteBackupSettingsButton.Size = new System.Drawing.Size(93, 23);
            this.deleteBackupSettingsButton.TabIndex = 0;
            this.deleteBackupSettingsButton.Text = "Töröl";
            this.deleteBackupSettingsButton.UseVisualStyleBackColor = true;
            this.deleteBackupSettingsButton.Click += new System.EventHandler(this.deleteBackupSettingsButton_Click);
            // 
            // BackupManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.quickBackupGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupManagerForm";
            this.Text = "Mentések kezelése";
            this.quickBackupGroupBox.ResumeLayout(false);
            this.quickBackupGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox quickBackupGroupBox;
        private System.Windows.Forms.Label toolLabel;
        private System.Windows.Forms.ComboBox cliToolComboBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Button browseSourceButton;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox saveAsNameTextBox;
        private System.Windows.Forms.Label saveAsNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Button browseTargetButton;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Button startBackupButton;
        private System.Windows.Forms.CheckBox incrementalCheckBox;
        private System.Windows.Forms.FolderBrowserDialog sourceFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog targetFolderBrowserDialog;
        private System.Windows.Forms.Button saveBackupSettingsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteBackupSettingsButton;
        private System.Windows.Forms.Button newBackupSettingsButton;
        private BackupSettingsPicker backupSettingsPicker;
    }
}