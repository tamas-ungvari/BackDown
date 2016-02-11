namespace BackDown
{
    partial class CliToolForm
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
            this.components = new System.ComponentModel.Container();
            this.backupGroupBox = new System.Windows.Forms.GroupBox();
            this.backupCommandTextBox = new System.Windows.Forms.TextBox();
            this.restoreGroupBox = new System.Windows.Forms.GroupBox();
            this.restoreCommandTextBox = new System.Windows.Forms.TextBox();
            this.cliToolNameLabel = new System.Windows.Forms.Label();
            this.cliToolNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sourcePlaceholderLabel = new System.Windows.Forms.Label();
            this.targetPlaceholderLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.backupGroupBox.SuspendLayout();
            this.restoreGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // backupGroupBox
            // 
            this.backupGroupBox.Controls.Add(this.backupCommandTextBox);
            this.backupGroupBox.Location = new System.Drawing.Point(12, 99);
            this.backupGroupBox.Name = "backupGroupBox";
            this.backupGroupBox.Size = new System.Drawing.Size(589, 106);
            this.backupGroupBox.TabIndex = 1;
            this.backupGroupBox.TabStop = false;
            this.backupGroupBox.Text = "Mentés parancs";
            // 
            // backupCommandTextBox
            // 
            this.backupCommandTextBox.Location = new System.Drawing.Point(6, 19);
            this.backupCommandTextBox.Multiline = true;
            this.backupCommandTextBox.Name = "backupCommandTextBox";
            this.backupCommandTextBox.Size = new System.Drawing.Size(577, 77);
            this.backupCommandTextBox.TabIndex = 1;
            this.backupCommandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBackupCommand_Validating);
            // 
            // restoreGroupBox
            // 
            this.restoreGroupBox.Controls.Add(this.restoreCommandTextBox);
            this.restoreGroupBox.Location = new System.Drawing.Point(12, 211);
            this.restoreGroupBox.Name = "restoreGroupBox";
            this.restoreGroupBox.Size = new System.Drawing.Size(589, 108);
            this.restoreGroupBox.TabIndex = 3;
            this.restoreGroupBox.TabStop = false;
            this.restoreGroupBox.Text = "Helyreállítás parancs";
            // 
            // restoreCommandTextBox
            // 
            this.restoreCommandTextBox.Location = new System.Drawing.Point(9, 19);
            this.restoreCommandTextBox.Multiline = true;
            this.restoreCommandTextBox.Name = "restoreCommandTextBox";
            this.restoreCommandTextBox.Size = new System.Drawing.Size(577, 78);
            this.restoreCommandTextBox.TabIndex = 3;
            this.restoreCommandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxRestoreCommand_Validating);
            // 
            // cliToolNameLabel
            // 
            this.cliToolNameLabel.AutoSize = true;
            this.cliToolNameLabel.Location = new System.Drawing.Point(6, 18);
            this.cliToolNameLabel.Name = "cliToolNameLabel";
            this.cliToolNameLabel.Size = new System.Drawing.Size(27, 13);
            this.cliToolNameLabel.TabIndex = 2;
            this.cliToolNameLabel.Text = "Név";
            // 
            // cliToolNameTextBox
            // 
            this.cliToolNameTextBox.Location = new System.Drawing.Point(39, 15);
            this.cliToolNameTextBox.Name = "cliToolNameTextBox";
            this.cliToolNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.cliToolNameTextBox.TabIndex = 3;
            this.cliToolNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCliToolName_Validating);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(225, 13);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(182, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Parancssori eszköz mentése";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(502, 13);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(81, 23);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Exportálás";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cliToolNameTextBox);
            this.groupBox1.Controls.Add(this.exportButton);
            this.groupBox1.Controls.Add(this.cliToolNameLabel);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // sourcePlaceholderLabel
            // 
            this.sourcePlaceholderLabel.AutoSize = true;
            this.sourcePlaceholderLabel.Location = new System.Drawing.Point(13, 72);
            this.sourcePlaceholderLabel.Name = "sourcePlaceholderLabel";
            this.sourcePlaceholderLabel.Size = new System.Drawing.Size(92, 13);
            this.sourcePlaceholderLabel.TabIndex = 8;
            this.sourcePlaceholderLabel.Text = "Forrás referencia: ";
            // 
            // targetPlaceholderLabel
            // 
            this.targetPlaceholderLabel.AutoSize = true;
            this.targetPlaceholderLabel.Location = new System.Drawing.Point(234, 72);
            this.targetPlaceholderLabel.Name = "targetPlaceholderLabel";
            this.targetPlaceholderLabel.Size = new System.Drawing.Size(78, 13);
            this.targetPlaceholderLabel.TabIndex = 8;
            this.targetPlaceholderLabel.Text = "Cél referencia: ";
            // 
            // CliToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 331);
            this.Controls.Add(this.targetPlaceholderLabel);
            this.Controls.Add(this.sourcePlaceholderLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.restoreGroupBox);
            this.Controls.Add(this.backupGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CliToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új Parancssori Eszköz";
            this.backupGroupBox.ResumeLayout(false);
            this.backupGroupBox.PerformLayout();
            this.restoreGroupBox.ResumeLayout(false);
            this.restoreGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox backupGroupBox;
        private System.Windows.Forms.GroupBox restoreGroupBox;
        private System.Windows.Forms.TextBox backupCommandTextBox;
        private System.Windows.Forms.TextBox restoreCommandTextBox;
        private System.Windows.Forms.Label cliToolNameLabel;
        private System.Windows.Forms.TextBox cliToolNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label sourcePlaceholderLabel;
        private System.Windows.Forms.Label targetPlaceholderLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}