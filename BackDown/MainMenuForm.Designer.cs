namespace BackDown
{
    partial class MainMenuForm
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
            this.buttonRecover.Text = "Napló és Helyreállítás";
            this.buttonRecover.UseVisualStyleBackColor = true;
            this.buttonRecover.Click += new System.EventHandler(this.buttonRecover_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 105);
            this.Controls.Add(this.buttonRecover);
            this.Controls.Add(this.buttonManageBackups);
            this.Controls.Add(this.buttonManageCliTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "BackDown";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageCliTools;
        private System.Windows.Forms.Button buttonManageBackups;
        private System.Windows.Forms.Button buttonRecover;
    }
}

