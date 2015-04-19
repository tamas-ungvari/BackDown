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
            this.groupBoxBackup = new System.Windows.Forms.GroupBox();
            this.labelBackupCommand = new System.Windows.Forms.Label();
            this.textBoxBackupCommand = new System.Windows.Forms.TextBox();
            this.groupBoxRestore = new System.Windows.Forms.GroupBox();
            this.textBoxRestoreCommand = new System.Windows.Forms.TextBox();
            this.labelRestoreCommand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCliToolName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxIncrementalBackup = new System.Windows.Forms.GroupBox();
            this.labelIncrementalBackupCommand = new System.Windows.Forms.Label();
            this.textBoxIncrementalBackupCommand = new System.Windows.Forms.TextBox();
            this.groupBoxBackup.SuspendLayout();
            this.groupBoxRestore.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxIncrementalBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBackup
            // 
            this.groupBoxBackup.Controls.Add(this.labelBackupCommand);
            this.groupBoxBackup.Controls.Add(this.textBoxBackupCommand);
            this.groupBoxBackup.Location = new System.Drawing.Point(12, 62);
            this.groupBoxBackup.Name = "groupBoxBackup";
            this.groupBoxBackup.Size = new System.Drawing.Size(589, 106);
            this.groupBoxBackup.TabIndex = 0;
            this.groupBoxBackup.TabStop = false;
            this.groupBoxBackup.Text = "Mentés";
            // 
            // labelBackupCommand
            // 
            this.labelBackupCommand.AutoSize = true;
            this.labelBackupCommand.Location = new System.Drawing.Point(6, 16);
            this.labelBackupCommand.Name = "labelBackupCommand";
            this.labelBackupCommand.Size = new System.Drawing.Size(83, 13);
            this.labelBackupCommand.TabIndex = 0;
            this.labelBackupCommand.Text = "Mentés parancs";
            // 
            // textBoxBackupCommand
            // 
            this.textBoxBackupCommand.Location = new System.Drawing.Point(6, 32);
            this.textBoxBackupCommand.Multiline = true;
            this.textBoxBackupCommand.Name = "textBoxBackupCommand";
            this.textBoxBackupCommand.Size = new System.Drawing.Size(577, 64);
            this.textBoxBackupCommand.TabIndex = 1;
            // 
            // groupBoxRestore
            // 
            this.groupBoxRestore.Controls.Add(this.textBoxRestoreCommand);
            this.groupBoxRestore.Controls.Add(this.labelRestoreCommand);
            this.groupBoxRestore.Location = new System.Drawing.Point(12, 286);
            this.groupBoxRestore.Name = "groupBoxRestore";
            this.groupBoxRestore.Size = new System.Drawing.Size(589, 108);
            this.groupBoxRestore.TabIndex = 1;
            this.groupBoxRestore.TabStop = false;
            this.groupBoxRestore.Text = "Helyreállítás";
            // 
            // textBoxRestoreCommand
            // 
            this.textBoxRestoreCommand.Location = new System.Drawing.Point(6, 32);
            this.textBoxRestoreCommand.Multiline = true;
            this.textBoxRestoreCommand.Name = "textBoxRestoreCommand";
            this.textBoxRestoreCommand.Size = new System.Drawing.Size(577, 65);
            this.textBoxRestoreCommand.TabIndex = 3;
            // 
            // labelRestoreCommand
            // 
            this.labelRestoreCommand.AutoSize = true;
            this.labelRestoreCommand.Location = new System.Drawing.Point(6, 16);
            this.labelRestoreCommand.Name = "labelRestoreCommand";
            this.labelRestoreCommand.Size = new System.Drawing.Size(106, 13);
            this.labelRestoreCommand.TabIndex = 1;
            this.labelRestoreCommand.Text = "Helyreállítás parancs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // textBoxCliToolName
            // 
            this.textBoxCliToolName.Location = new System.Drawing.Point(39, 15);
            this.textBoxCliToolName.Name = "textBoxCliToolName";
            this.textBoxCliToolName.Size = new System.Drawing.Size(207, 20);
            this.textBoxCliToolName.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(252, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(169, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Parancssori eszköz mentése";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(427, 13);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 5;
            this.buttonImport.Text = "Importálás";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(508, 13);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.Text = "Exportálás";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCliToolName);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonImport);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxIncrementalBackup
            // 
            this.groupBoxIncrementalBackup.Controls.Add(this.labelIncrementalBackupCommand);
            this.groupBoxIncrementalBackup.Controls.Add(this.textBoxIncrementalBackupCommand);
            this.groupBoxIncrementalBackup.Location = new System.Drawing.Point(12, 174);
            this.groupBoxIncrementalBackup.Name = "groupBoxIncrementalBackup";
            this.groupBoxIncrementalBackup.Size = new System.Drawing.Size(589, 106);
            this.groupBoxIncrementalBackup.TabIndex = 2;
            this.groupBoxIncrementalBackup.TabStop = false;
            this.groupBoxIncrementalBackup.Text = "Inkrementális Mentés";
            // 
            // labelIncrementalBackupCommand
            // 
            this.labelIncrementalBackupCommand.AutoSize = true;
            this.labelIncrementalBackupCommand.Location = new System.Drawing.Point(6, 16);
            this.labelIncrementalBackupCommand.Name = "labelIncrementalBackupCommand";
            this.labelIncrementalBackupCommand.Size = new System.Drawing.Size(147, 13);
            this.labelIncrementalBackupCommand.TabIndex = 0;
            this.labelIncrementalBackupCommand.Text = "Inkrementális mentés parancs";
            // 
            // textBoxIncrementalBackupCommand
            // 
            this.textBoxIncrementalBackupCommand.Location = new System.Drawing.Point(9, 32);
            this.textBoxIncrementalBackupCommand.Multiline = true;
            this.textBoxIncrementalBackupCommand.Name = "textBoxIncrementalBackupCommand";
            this.textBoxIncrementalBackupCommand.Size = new System.Drawing.Size(574, 64);
            this.textBoxIncrementalBackupCommand.TabIndex = 1;
            // 
            // CliToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 405);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBackup;
        private System.Windows.Forms.Label labelBackupCommand;
        private System.Windows.Forms.GroupBox groupBoxRestore;
        private System.Windows.Forms.TextBox textBoxBackupCommand;
        private System.Windows.Forms.TextBox textBoxRestoreCommand;
        private System.Windows.Forms.Label labelRestoreCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCliToolName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxIncrementalBackup;
        private System.Windows.Forms.Label labelIncrementalBackupCommand;
        private System.Windows.Forms.TextBox textBoxIncrementalBackupCommand;
    }
}