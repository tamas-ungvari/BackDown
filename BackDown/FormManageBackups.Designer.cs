namespace BackDown
{
    partial class FormManageBackups
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
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveAsNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.browseTargetButton = new System.Windows.Forms.Button();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseSourceButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cliToolComboBox = new System.Windows.Forms.ComboBox();
            this.startQuickBackupButton = new System.Windows.Forms.Button();
            this.incrementalCheckBox = new System.Windows.Forms.CheckBox();
            this.sourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.targetFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveBackupSettingsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startBackupButton = new System.Windows.Forms.Button();
            this.journalButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incremental = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quickBackupGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // quickBackupGroupBox
            // 
            this.quickBackupGroupBox.Controls.Add(this.incrementalCheckBox);
            this.quickBackupGroupBox.Controls.Add(this.startQuickBackupButton);
            this.quickBackupGroupBox.Controls.Add(this.noteTextBox);
            this.quickBackupGroupBox.Controls.Add(this.groupBox1);
            this.quickBackupGroupBox.Controls.Add(this.label4);
            this.quickBackupGroupBox.Controls.Add(this.label3);
            this.quickBackupGroupBox.Controls.Add(this.browseTargetButton);
            this.quickBackupGroupBox.Controls.Add(this.targetTextBox);
            this.quickBackupGroupBox.Controls.Add(this.label2);
            this.quickBackupGroupBox.Controls.Add(this.browseSourceButton);
            this.quickBackupGroupBox.Controls.Add(this.sourceTextBox);
            this.quickBackupGroupBox.Controls.Add(this.label1);
            this.quickBackupGroupBox.Controls.Add(this.cliToolComboBox);
            this.quickBackupGroupBox.Location = new System.Drawing.Point(12, 12);
            this.quickBackupGroupBox.Name = "quickBackupGroupBox";
            this.quickBackupGroupBox.Size = new System.Drawing.Size(587, 239);
            this.quickBackupGroupBox.TabIndex = 0;
            this.quickBackupGroupBox.TabStop = false;
            this.quickBackupGroupBox.Text = "Mentés";
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
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beállítások tárolása";
            // 
            // saveAsNameTextBox
            // 
            this.saveAsNameTextBox.Location = new System.Drawing.Point(131, 19);
            this.saveAsNameTextBox.Name = "saveAsNameTextBox";
            this.saveAsNameTextBox.Size = new System.Drawing.Size(308, 20);
            this.saveAsNameTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Név";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cél mappa";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Forrás mappa";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parancssoros eszköz";
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
            // startQuickBackupButton
            // 
            this.startQuickBackupButton.Location = new System.Drawing.Point(220, 202);
            this.startQuickBackupButton.Name = "startQuickBackupButton";
            this.startQuickBackupButton.Size = new System.Drawing.Size(136, 28);
            this.startQuickBackupButton.TabIndex = 10;
            this.startQuickBackupButton.Text = "Gyorsmentés indítása";
            this.startQuickBackupButton.UseVisualStyleBackColor = true;
            this.startQuickBackupButton.Click += new System.EventHandler(this.startQuickBackupButton_Click);
            // 
            // incrementalCheckBox
            // 
            this.incrementalCheckBox.AutoSize = true;
            this.incrementalCheckBox.Location = new System.Drawing.Point(137, 46);
            this.incrementalCheckBox.Name = "incrementalCheckBox";
            this.incrementalCheckBox.Size = new System.Drawing.Size(125, 17);
            this.incrementalCheckBox.TabIndex = 11;
            this.incrementalCheckBox.Text = "Inkrementális mentés";
            this.incrementalCheckBox.UseVisualStyleBackColor = true;
            // 
            // sourceFolderBrowserDialog
            // 
            this.sourceFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // backupBindingSource
            // 
            this.backupBindingSource.DataSource = typeof(BackDown.Backup);
            // 
            // saveBackupSettingsButton
            // 
            this.saveBackupSettingsButton.Location = new System.Drawing.Point(445, 17);
            this.saveBackupSettingsButton.Name = "saveBackupSettingsButton";
            this.saveBackupSettingsButton.Size = new System.Drawing.Size(124, 23);
            this.saveBackupSettingsButton.TabIndex = 12;
            this.saveBackupSettingsButton.Text = "Beállítás eltárolása";
            this.saveBackupSettingsButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startBackupButton);
            this.groupBox2.Controls.Add(this.journalButton);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tárolt beállítások";
            // 
            // startBackupButton
            // 
            this.startBackupButton.Location = new System.Drawing.Point(6, 19);
            this.startBackupButton.Name = "startBackupButton";
            this.startBackupButton.Size = new System.Drawing.Size(131, 23);
            this.startBackupButton.TabIndex = 7;
            this.startBackupButton.Text = "Mentés készítése";
            this.startBackupButton.UseVisualStyleBackColor = true;
            // 
            // journalButton
            // 
            this.journalButton.Location = new System.Drawing.Point(143, 19);
            this.journalButton.Name = "journalButton";
            this.journalButton.Size = new System.Drawing.Size(119, 23);
            this.journalButton.TabIndex = 6;
            this.journalButton.Text = "Napló";
            this.journalButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.targetDataGridViewTextBoxColumn,
            this.Incremental});
            this.dataGridView1.DataSource = this.backupBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 230);
            this.dataGridView1.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // FormManageBackups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.quickBackupGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormManageBackups";
            this.Text = "Mentések kezelése";
            this.quickBackupGroupBox.ResumeLayout(false);
            this.quickBackupGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox quickBackupGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cliToolComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseSourceButton;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox saveAsNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button browseTargetButton;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Button startQuickBackupButton;
        private System.Windows.Forms.CheckBox incrementalCheckBox;
        private System.Windows.Forms.FolderBrowserDialog sourceFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog targetFolderBrowserDialog;
        private System.Windows.Forms.BindingSource backupBindingSource;
        private System.Windows.Forms.Button saveBackupSettingsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button startBackupButton;
        private System.Windows.Forms.Button journalButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Incremental;
    }
}