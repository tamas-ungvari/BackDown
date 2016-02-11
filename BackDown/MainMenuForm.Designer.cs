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
            this.manageCliToolsButton = new System.Windows.Forms.Button();
            this.manageBackupsButton = new System.Windows.Forms.Button();
            this.recoverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageCliToolsButton
            // 
            this.manageCliToolsButton.Location = new System.Drawing.Point(16, 12);
            this.manageCliToolsButton.Name = "manageCliToolsButton";
            this.manageCliToolsButton.Size = new System.Drawing.Size(220, 23);
            this.manageCliToolsButton.TabIndex = 0;
            this.manageCliToolsButton.Text = "Parancssori eszközök kezelése";
            this.manageCliToolsButton.UseVisualStyleBackColor = true;
            this.manageCliToolsButton.Click += new System.EventHandler(this.manageCliToolsButton_Click);
            // 
            // manageBackupsButton
            // 
            this.manageBackupsButton.Location = new System.Drawing.Point(16, 41);
            this.manageBackupsButton.Name = "manageBackupsButton";
            this.manageBackupsButton.Size = new System.Drawing.Size(220, 23);
            this.manageBackupsButton.TabIndex = 1;
            this.manageBackupsButton.Text = "Mentések kezelése";
            this.manageBackupsButton.UseVisualStyleBackColor = true;
            this.manageBackupsButton.Click += new System.EventHandler(this.manageBackupsButton_Click);
            // 
            // recoverButton
            // 
            this.recoverButton.Location = new System.Drawing.Point(16, 70);
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.Size = new System.Drawing.Size(220, 23);
            this.recoverButton.TabIndex = 2;
            this.recoverButton.Text = "Napló és Helyreállítás";
            this.recoverButton.UseVisualStyleBackColor = true;
            this.recoverButton.Click += new System.EventHandler(this.recoverButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 105);
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.manageBackupsButton);
            this.Controls.Add(this.manageCliToolsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackDown";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageCliToolsButton;
        private System.Windows.Forms.Button manageBackupsButton;
        private System.Windows.Forms.Button recoverButton;
    }
}

