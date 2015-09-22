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
            this.groupBoxBackup = new System.Windows.Forms.GroupBox();
            this.textBoxBackupCommand = new System.Windows.Forms.TextBox();
            this.groupBoxRestore = new System.Windows.Forms.GroupBox();
            this.textBoxRestoreCommand = new System.Windows.Forms.TextBox();
            this.labelCliToolName = new System.Windows.Forms.Label();
            this.textBoxCliToolName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxIncrementalBackup = new System.Windows.Forms.GroupBox();
            this.textBoxIncrementalBackupCommand = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sourcePlaceholderLabel = new System.Windows.Forms.Label();
            this.targetPlaceholderLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxBackup.SuspendLayout();
            this.groupBoxRestore.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxIncrementalBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBackup
            // 
            this.groupBoxBackup.Controls.Add(this.textBoxBackupCommand);
            this.groupBoxBackup.Location = new System.Drawing.Point(12, 99);
            this.groupBoxBackup.Name = "groupBoxBackup";
            this.groupBoxBackup.Size = new System.Drawing.Size(589, 106);
            this.groupBoxBackup.TabIndex = 1;
            this.groupBoxBackup.TabStop = false;
            this.groupBoxBackup.Text = "Mentés parancs";
            // 
            // textBoxBackupCommand
            // 
            this.textBoxBackupCommand.Location = new System.Drawing.Point(6, 19);
            this.textBoxBackupCommand.Multiline = true;
            this.textBoxBackupCommand.Name = "textBoxBackupCommand";
            this.textBoxBackupCommand.Size = new System.Drawing.Size(577, 77);
            this.textBoxBackupCommand.TabIndex = 1;
            this.textBoxBackupCommand.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBackupCommand_Validating);
            // 
            // groupBoxRestore
            // 
            this.groupBoxRestore.Controls.Add(this.textBoxRestoreCommand);
            this.groupBoxRestore.Location = new System.Drawing.Point(12, 323);
            this.groupBoxRestore.Name = "groupBoxRestore";
            this.groupBoxRestore.Size = new System.Drawing.Size(589, 108);
            this.groupBoxRestore.TabIndex = 3;
            this.groupBoxRestore.TabStop = false;
            this.groupBoxRestore.Text = "Helyreállítás parancs";
            // 
            // textBoxRestoreCommand
            // 
            this.textBoxRestoreCommand.Location = new System.Drawing.Point(6, 19);
            this.textBoxRestoreCommand.Multiline = true;
            this.textBoxRestoreCommand.Name = "textBoxRestoreCommand";
            this.textBoxRestoreCommand.Size = new System.Drawing.Size(577, 78);
            this.textBoxRestoreCommand.TabIndex = 3;
            this.textBoxRestoreCommand.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxRestoreCommand_Validating);
            // 
            // labelCliToolName
            // 
            this.labelCliToolName.AutoSize = true;
            this.labelCliToolName.Location = new System.Drawing.Point(6, 18);
            this.labelCliToolName.Name = "labelCliToolName";
            this.labelCliToolName.Size = new System.Drawing.Size(27, 13);
            this.labelCliToolName.TabIndex = 2;
            this.labelCliToolName.Text = "Név";
            // 
            // textBoxCliToolName
            // 
            this.textBoxCliToolName.Location = new System.Drawing.Point(39, 15);
            this.textBoxCliToolName.Name = "textBoxCliToolName";
            this.textBoxCliToolName.Size = new System.Drawing.Size(180, 20);
            this.textBoxCliToolName.TabIndex = 3;
            this.textBoxCliToolName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCliToolName_Validating);
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(225, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(182, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Parancssori eszköz mentése";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(502, 13);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(81, 23);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.Text = "Exportálás";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCliToolName);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.labelCliToolName);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxIncrementalBackup
            // 
            this.groupBoxIncrementalBackup.Controls.Add(this.textBoxIncrementalBackupCommand);
            this.groupBoxIncrementalBackup.Location = new System.Drawing.Point(12, 211);
            this.groupBoxIncrementalBackup.Name = "groupBoxIncrementalBackup";
            this.groupBoxIncrementalBackup.Size = new System.Drawing.Size(589, 106);
            this.groupBoxIncrementalBackup.TabIndex = 2;
            this.groupBoxIncrementalBackup.TabStop = false;
            this.groupBoxIncrementalBackup.Text = "Inkrementális mentés parancs";
            // 
            // textBoxIncrementalBackupCommand
            // 
            this.textBoxIncrementalBackupCommand.Location = new System.Drawing.Point(9, 19);
            this.textBoxIncrementalBackupCommand.Multiline = true;
            this.textBoxIncrementalBackupCommand.Name = "textBoxIncrementalBackupCommand";
            this.textBoxIncrementalBackupCommand.Size = new System.Drawing.Size(574, 77);
            this.textBoxIncrementalBackupCommand.TabIndex = 1;
            this.textBoxIncrementalBackupCommand.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIncrementalBackupCommand_Validating);
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
            this.ClientSize = new System.Drawing.Size(613, 443);
            this.Controls.Add(this.targetPlaceholderLabel);
            this.Controls.Add(this.sourcePlaceholderLabel);
            this.Controls.Add(this.groupBoxIncrementalBackup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRestore);
            this.Controls.Add(this.groupBoxBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CliToolForm";
            this.Text = "Új Parancssori Eszköz";
            this.groupBoxBackup.ResumeLayout(false);
            this.groupBoxBackup.PerformLayout();
            this.groupBoxRestore.ResumeLayout(false);
            this.groupBoxRestore.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxIncrementalBackup.ResumeLayout(false);
            this.groupBoxIncrementalBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBackup;
        private System.Windows.Forms.GroupBox groupBoxRestore;
        private System.Windows.Forms.TextBox textBoxBackupCommand;
        private System.Windows.Forms.TextBox textBoxRestoreCommand;
        private System.Windows.Forms.Label labelCliToolName;
        private System.Windows.Forms.TextBox textBoxCliToolName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxIncrementalBackup;
        private System.Windows.Forms.TextBox textBoxIncrementalBackupCommand;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label sourcePlaceholderLabel;
        private System.Windows.Forms.Label targetPlaceholderLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}