namespace BackDown
{
    partial class BackupSettingsPicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backupSettingsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliTool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incremental = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.backupSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.backupSettingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.backupSettingsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupSettingsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.backupSettingsDataGridView.Name = "backupSettingsDataGridView";
            this.backupSettingsDataGridView.ReadOnly = true;
            this.backupSettingsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.backupSettingsDataGridView.Size = new System.Drawing.Size(735, 230);
            this.backupSettingsDataGridView.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CliTool
            // 
            this.CliTool.DataPropertyName = "CliToolName";
            this.CliTool.HeaderText = "Eszköz";
            this.CliTool.Name = "CliTool";
            this.CliTool.ReadOnly = true;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Forrás mappa";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // targetDataGridViewTextBoxColumn
            // 
            this.targetDataGridViewTextBoxColumn.DataPropertyName = "Target";
            this.targetDataGridViewTextBoxColumn.HeaderText = "Cél mappa";
            this.targetDataGridViewTextBoxColumn.Name = "targetDataGridViewTextBoxColumn";
            this.targetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Incremental
            // 
            this.Incremental.DataPropertyName = "Incremental";
            this.Incremental.HeaderText = "Inkrementális";
            this.Incremental.Name = "Incremental";
            this.Incremental.ReadOnly = true;
            // 
            // backupSettingsBindingSource
            // 
            this.backupSettingsBindingSource.DataSource = typeof(BackDown.BackupSettings);
            // 
            // BackupSettingsPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backupSettingsDataGridView);
            this.Name = "BackupSettingsPicker";
            this.Size = new System.Drawing.Size(735, 230);
            this.Load += new System.EventHandler(this.BackupSettingsPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backupSettingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource backupSettingsBindingSource;
        private System.Windows.Forms.DataGridView backupSettingsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Incremental;

    }
}
