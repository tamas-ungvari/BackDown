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
            this.components = new System.ComponentModel.Container();
            this.quickBackupGroupBox = new System.Windows.Forms.GroupBox();
            this.incrementalCheckBox = new System.Windows.Forms.CheckBox();
            this.startBackupButton = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBackupSettingsButton = new System.Windows.Forms.Button();
            this.saveAsNameTextBox = new System.Windows.Forms.TextBox();
            this.saveAsNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
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
            this.deleteBackupSettingsButton = new System.Windows.Forms.Button();
            this.journalButton = new System.Windows.Forms.Button();
            this.backupSettingsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliTool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incremental = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.backupSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quickBackupGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupSettingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quickBackupGroupBox
            // 
            this.quickBackupGroupBox.Controls.Add(this.incrementalCheckBox);
            this.quickBackupGroupBox.Controls.Add(this.startBackupButton);
            this.quickBackupGroupBox.Controls.Add(this.noteTextBox);
            this.quickBackupGroupBox.Controls.Add(this.groupBox1);
            this.quickBackupGroupBox.Controls.Add(this.label4);
            this.quickBackupGroupBox.Controls.Add(this.targetLabel);
            this.quickBackupGroupBox.Controls.Add(this.browseTargetButton);
            this.quickBackupGroupBox.Controls.Add(this.targetTextBox);
            this.quickBackupGroupBox.Controls.Add(this.sourceLabel);
            this.quickBackupGroupBox.Controls.Add(this.browseSourceButton);
            this.quickBackupGroupBox.Controls.Add(this.sourceTextBox);
            this.quickBackupGroupBox.Controls.Add(this.toolLabel);
            this.quickBackupGroupBox.Controls.Add(this.cliToolComboBox);
            this.quickBackupGroupBox.Location = new System.Drawing.Point(85, 12);
            this.quickBackupGroupBox.Name = "quickBackupGroupBox";
            this.quickBackupGroupBox.Size = new System.Drawing.Size(587, 239);
            this.quickBackupGroupBox.TabIndex = 0;
            this.quickBackupGroupBox.TabStop = false;
            this.quickBackupGroupBox.Text = "Mentés";
            // 
            // incrementalCheckBox
            // 
            this.incrementalCheckBox.AutoSize = true;
            this.incrementalCheckBox.Location = new System.Drawing.Point(137, 46);
            this.incrementalCheckBox.Name = "incrementalCheckBox";
            this.incrementalCheckBox.Size = new System.Drawing.Size(125, 17);
            this.incrementalCheckBox.TabIndex = 2;
            this.incrementalCheckBox.Text = "Inkrementális mentés";
            this.incrementalCheckBox.UseVisualStyleBackColor = true;
            // 
            // startBackupButton
            // 
            this.startBackupButton.Location = new System.Drawing.Point(220, 202);
            this.startBackupButton.Name = "startBackupButton";
            this.startBackupButton.Size = new System.Drawing.Size(136, 28);
            this.startBackupButton.TabIndex = 10;
            this.startBackupButton.Text = "Mentés indítása";
            this.startBackupButton.UseVisualStyleBackColor = true;
            this.startBackupButton.Click += new System.EventHandler(this.startBackupButton_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(137, 121);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(308, 20);
            this.noteTextBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveBackupSettingsButton);
            this.groupBox1.Controls.Add(this.saveAsNameTextBox);
            this.groupBox1.Controls.Add(this.saveAsNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beállítások tárolása";
            // 
            // saveBackupSettingsButton
            // 
            this.saveBackupSettingsButton.Location = new System.Drawing.Point(445, 17);
            this.saveBackupSettingsButton.Name = "saveBackupSettingsButton";
            this.saveBackupSettingsButton.Size = new System.Drawing.Size(124, 23);
            this.saveBackupSettingsButton.TabIndex = 12;
            this.saveBackupSettingsButton.Text = "Beállítás eltárolása";
            this.saveBackupSettingsButton.UseVisualStyleBackColor = true;
            this.saveBackupSettingsButton.Click += new System.EventHandler(this.saveBackupSettingsButton_Click);
            // 
            // saveAsNameTextBox
            // 
            this.saveAsNameTextBox.Location = new System.Drawing.Point(131, 19);
            this.saveAsNameTextBox.Name = "saveAsNameTextBox";
            this.saveAsNameTextBox.Size = new System.Drawing.Size(308, 20);
            this.saveAsNameTextBox.TabIndex = 10;
            // 
            // saveAsNameLabel
            // 
            this.saveAsNameLabel.AutoSize = true;
            this.saveAsNameLabel.Location = new System.Drawing.Point(98, 22);
            this.saveAsNameLabel.Name = "saveAsNameLabel";
            this.saveAsNameLabel.Size = new System.Drawing.Size(27, 13);
            this.saveAsNameLabel.TabIndex = 11;
            this.saveAsNameLabel.Text = "Név";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Megjegyzés (opcionális)";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(74, 98);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(57, 13);
            this.targetLabel.TabIndex = 7;
            this.targetLabel.Text = "Cél mappa";
            // 
            // browseTargetButton
            // 
            this.browseTargetButton.Location = new System.Drawing.Point(451, 93);
            this.browseTargetButton.Name = "browseTargetButton";
            this.browseTargetButton.Size = new System.Drawing.Size(124, 23);
            this.browseTargetButton.TabIndex = 6;
            this.browseTargetButton.Text = "Tallóz ...";
            this.browseTargetButton.UseVisualStyleBackColor = true;
            this.browseTargetButton.Click += new System.EventHandler(this.browseTargetButton_Click);
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(137, 95);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(308, 20);
            this.targetTextBox.TabIndex = 5;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(60, 72);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(71, 13);
            this.sourceLabel.TabIndex = 4;
            this.sourceLabel.Text = "Forrás mappa";
            // 
            // browseSourceButton
            // 
            this.browseSourceButton.Location = new System.Drawing.Point(451, 67);
            this.browseSourceButton.Name = "browseSourceButton";
            this.browseSourceButton.Size = new System.Drawing.Size(124, 23);
            this.browseSourceButton.TabIndex = 3;
            this.browseSourceButton.Text = "Tallóz ...";
            this.browseSourceButton.UseVisualStyleBackColor = true;
            this.browseSourceButton.Click += new System.EventHandler(this.browseSourceButton_Click);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(137, 69);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(308, 20);
            this.sourceTextBox.TabIndex = 2;
            // 
            // toolLabel
            // 
            this.toolLabel.AutoSize = true;
            this.toolLabel.Location = new System.Drawing.Point(24, 22);
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(107, 13);
            this.toolLabel.TabIndex = 1;
            this.toolLabel.Text = "Parancssoros eszköz";
            // 
            // cliToolComboBox
            // 
            this.cliToolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cliToolComboBox.FormattingEnabled = true;
            this.cliToolComboBox.Location = new System.Drawing.Point(137, 19);
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
            this.groupBox2.Controls.Add(this.deleteBackupSettingsButton);
            this.groupBox2.Controls.Add(this.journalButton);
            this.groupBox2.Controls.Add(this.backupSettingsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tárolt beállítások";
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
            // journalButton
            // 
            this.journalButton.Enabled = false;
            this.journalButton.Location = new System.Drawing.Point(107, 19);
            this.journalButton.Name = "journalButton";
            this.journalButton.Size = new System.Drawing.Size(94, 23);
            this.journalButton.TabIndex = 1;
            this.journalButton.Text = "Napló";
            this.journalButton.UseVisualStyleBackColor = true;
            // 
            // backupSettingsDataGridView
            // 
            this.backupSettingsDataGridView.AllowUserToAddRows = false;
            this.backupSettingsDataGridView.AllowUserToDeleteRows = false;
            this.backupSettingsDataGridView.AutoGenerateColumns = false;
            this.backupSettingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.backupSettingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.CliTool,
            this.sourceDataGridViewTextBoxColumn,
            this.targetDataGridViewTextBoxColumn,
            this.Incremental});
            this.backupSettingsDataGridView.DataSource = this.backupSettingsBindingSource;
            this.backupSettingsDataGridView.Location = new System.Drawing.Point(6, 48);
            this.backupSettingsDataGridView.Name = "backupSettingsDataGridView";
            this.backupSettingsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.backupSettingsDataGridView.Size = new System.Drawing.Size(735, 230);
            this.backupSettingsDataGridView.TabIndex = 2;
            this.backupSettingsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.backupSettingsDataGridView_RowEnter);
            this.backupSettingsDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.backupSettingsDataGridView_RowsRemoved);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // CliTool
            // 
            this.CliTool.DataPropertyName = "CliTool.Name";
            this.CliTool.HeaderText = "Eszköz";
            this.CliTool.Name = "CliTool";
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Forrás mappa";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            // 
            // targetDataGridViewTextBoxColumn
            // 
            this.targetDataGridViewTextBoxColumn.DataPropertyName = "Target";
            this.targetDataGridViewTextBoxColumn.HeaderText = "Cél mappa";
            this.targetDataGridViewTextBoxColumn.Name = "targetDataGridViewTextBoxColumn";
            // 
            // Incremental
            // 
            this.Incremental.DataPropertyName = "Incremental";
            this.Incremental.HeaderText = "Inkrementális";
            this.Incremental.Name = "Incremental";
            // 
            // backupSettingsBindingSource
            // 
            this.backupSettingsBindingSource.DataSource = typeof(BackDown.BackupSettings);
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
            this.Name = "BackupManagerForm";
            this.Text = "Mentések kezelése";
            this.quickBackupGroupBox.ResumeLayout(false);
            this.quickBackupGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backupSettingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupSettingsBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.BindingSource backupSettingsBindingSource;
        private System.Windows.Forms.Button saveBackupSettingsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteBackupSettingsButton;
        private System.Windows.Forms.Button journalButton;
        private System.Windows.Forms.DataGridView backupSettingsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Incremental;
    }
}