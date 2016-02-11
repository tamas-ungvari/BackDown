namespace BackDown
{
    partial class CliToolManagerForm
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
            this.cliToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.importButton = new System.Windows.Forms.Button();
            this.cliToolsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliToolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cliToolsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliToolsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliToolsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cliToolsGroupBox
            // 
            this.cliToolsGroupBox.Controls.Add(this.importButton);
            this.cliToolsGroupBox.Controls.Add(this.cliToolsDataGridView);
            this.cliToolsGroupBox.Controls.Add(this.deleteButton);
            this.cliToolsGroupBox.Controls.Add(this.editButton);
            this.cliToolsGroupBox.Controls.Add(this.newButton);
            this.cliToolsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.cliToolsGroupBox.Name = "cliToolsGroupBox";
            this.cliToolsGroupBox.Size = new System.Drawing.Size(471, 252);
            this.cliToolsGroupBox.TabIndex = 1;
            this.cliToolsGroupBox.TabStop = false;
            this.cliToolsGroupBox.Text = "Parancssori eszközök";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(128, 19);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(106, 23);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Importálás";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // cliToolsDataGridView
            // 
            this.cliToolsDataGridView.AllowUserToAddRows = false;
            this.cliToolsDataGridView.AllowUserToDeleteRows = false;
            this.cliToolsDataGridView.AutoGenerateColumns = false;
            this.cliToolsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cliToolsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cliToolsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.cliToolsDataGridView.DataSource = this.cliToolsBindingSource;
            this.cliToolsDataGridView.Location = new System.Drawing.Point(6, 49);
            this.cliToolsDataGridView.Name = "cliToolsDataGridView";
            this.cliToolsDataGridView.ReadOnly = true;
            this.cliToolsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cliToolsDataGridView.Size = new System.Drawing.Size(458, 197);
            this.cliToolsDataGridView.TabIndex = 4;
            this.cliToolsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.cliToolsDataGridView_RowEnter);
            this.cliToolsDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.cliToolsDataGridView_RowsRemoved);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 52;
            // 
            // cliToolsBindingSource
            // 
            this.cliToolsBindingSource.DataSource = typeof(BackDown.CliTool);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(358, 19);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Töröl";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(240, 19);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(112, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Szerkeszt";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(6, 19);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(116, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "Új";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // CliToolManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 276);
            this.Controls.Add(this.cliToolsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CliToolManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parancssori eszközök kezelése";
            this.cliToolsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cliToolsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliToolsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cliToolsGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.DataGridView cliToolsDataGridView;
        private System.Windows.Forms.BindingSource cliToolsBindingSource;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}