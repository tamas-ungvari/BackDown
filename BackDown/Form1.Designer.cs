namespace BackDown
{
    partial class FormBackDown
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
            this.buttonManageCliTools = new System.Windows.Forms.Button();
            this.buttonManageBackups = new System.Windows.Forms.Button();
            this.buttonRecover = new System.Windows.Forms.Button();
            this.buttonLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageCliTools
            // 
            this.buttonManageCliTools.Location = new System.Drawing.Point(16, 12);
            this.buttonManageCliTools.Name = "buttonManageCliTools";
            this.buttonManageCliTools.Size = new System.Drawing.Size(220, 23);
            this.buttonManageCliTools.TabIndex = 0;
            this.buttonManageCliTools.Text = "Parancssori eszközök kezelése";
            this.buttonManageCliTools.UseVisualStyleBackColor = true;
            this.buttonManageCliTools.Click += new System.EventHandler(this.buttonManageCliTools_Click);
            // 
            // buttonManageBackups
            // 
            this.buttonManageBackups.Location = new System.Drawing.Point(16, 41);
            this.buttonManageBackups.Name = "buttonManageBackups";
            this.buttonManageBackups.Size = new System.Drawing.Size(220, 23);
            this.buttonManageBackups.TabIndex = 1;
            this.buttonManageBackups.Text = "Mentések kezelése";
            this.buttonManageBackups.UseVisualStyleBackColor = true;
            this.buttonManageBackups.Click += new System.EventHandler(this.buttonManageBackups_Click);
            // 
            // buttonRecover
            // 
            this.buttonRecover.Location = new System.Drawing.Point(16, 70);
            this.buttonRecover.Name = "buttonRecover";
            this.buttonRecover.Size = new System.Drawing.Size(220, 23);
            this.buttonRecover.TabIndex = 2;
            this.buttonRecover.Text = "Helyreállítás";
            this.buttonRecover.UseVisualStyleBackColor = true;
            this.buttonRecover.Click += new System.EventHandler(this.buttonRecover_Click);
            // 
            // buttonLogs
            // 
            this.buttonLogs.Location = new System.Drawing.Point(16, 99);
            this.buttonLogs.Name = "buttonLogs";
            this.buttonLogs.Size = new System.Drawing.Size(220, 23);
            this.buttonLogs.TabIndex = 3;
            this.buttonLogs.Text = "Mentésnapló";
            this.buttonLogs.UseVisualStyleBackColor = true;
            this.buttonLogs.Click += new System.EventHandler(this.buttonLogs_Click);
            // 
            // FormBackDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 134);
            this.Controls.Add(this.buttonLogs);
            this.Controls.Add(this.buttonRecover);
            this.Controls.Add(this.buttonManageBackups);
            this.Controls.Add(this.buttonManageCliTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBackDown";
            this.Text = "BackDown";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageCliTools;
        private System.Windows.Forms.Button buttonManageBackups;
        private System.Windows.Forms.Button buttonRecover;
        private System.Windows.Forms.Button buttonLogs;
    }
}

