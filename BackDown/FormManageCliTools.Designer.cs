namespace BackDown
{
    partial class FormManageCliTools
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dataGridViewCliTools = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incrementalBackupEnabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceCliTools = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCliTools)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCliTools);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parancssori eszközök";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(246, 19);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Töröl";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(128, 19);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Szerkeszt";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(6, 19);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(116, 23);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "Új";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dataGridViewCliTools
            // 
            this.dataGridViewCliTools.AllowUserToAddRows = false;
            this.dataGridViewCliTools.AllowUserToDeleteRows = false;
            this.dataGridViewCliTools.AutoGenerateColumns = false;
            this.dataGridViewCliTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliTools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.incrementalBackupEnabledDataGridViewCheckBoxColumn});
            this.dataGridViewCliTools.DataSource = this.bindingSourceCliTools;
            this.dataGridViewCliTools.Location = new System.Drawing.Point(6, 49);
            this.dataGridViewCliTools.Name = "dataGridViewCliTools";
            this.dataGridViewCliTools.ReadOnly = true;
            this.dataGridViewCliTools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCliTools.Size = new System.Drawing.Size(346, 150);
            this.dataGridViewCliTools.TabIndex = 4;
            this.dataGridViewCliTools.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliTools_RowEnter);
            this.dataGridViewCliTools.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewCliTools_RowsRemoved);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incrementalBackupEnabledDataGridViewCheckBoxColumn
            // 
            this.incrementalBackupEnabledDataGridViewCheckBoxColumn.DataPropertyName = "IncrementalBackupEnabled";
            this.incrementalBackupEnabledDataGridViewCheckBoxColumn.HeaderText = "Inkrementális";
            this.incrementalBackupEnabledDataGridViewCheckBoxColumn.Name = "incrementalBackupEnabledDataGridViewCheckBoxColumn";
            this.incrementalBackupEnabledDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bindingSourceCliTools
            // 
            this.bindingSourceCliTools.DataSource = typeof(BackDown.CliTool);
            // 
            // FormManageCliTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 228);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormManageCliTools";
            this.Text = "Parancssori eszközök kezelése";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCliTools)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridView dataGridViewCliTools;
        private System.Windows.Forms.BindingSource bindingSourceCliTools;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn incrementalBackupEnabledDataGridViewCheckBoxColumn;
    }
}