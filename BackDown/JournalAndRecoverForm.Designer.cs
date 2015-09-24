namespace BackDown
{
    partial class JournalAndRecoverForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cliToolNameTextBox = new System.Windows.Forms.TextBox();
            this.journalButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.incrementalCheckBox = new System.Windows.Forms.CheckBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.toolLabel = new System.Windows.Forms.Label();
            this.restoreFolderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backupsListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.findByTargetButton = new System.Windows.Forms.Button();
            this.findByTargetBrowseButton = new System.Windows.Forms.Button();
            this.findByTargetTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.findByNameComboBox = new System.Windows.Forms.ComboBox();
            this.findByNameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.targetFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.restoreFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biztonsági mentések keresése";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cliToolNameTextBox);
            this.groupBox4.Controls.Add(this.journalButton);
            this.groupBox4.Controls.Add(this.restoreButton);
            this.groupBox4.Controls.Add(this.incrementalCheckBox);
            this.groupBox4.Controls.Add(this.targetLabel);
            this.groupBox4.Controls.Add(this.targetTextBox);
            this.groupBox4.Controls.Add(this.sourceLabel);
            this.groupBox4.Controls.Add(this.sourceTextBox);
            this.groupBox4.Controls.Add(this.toolLabel);
            this.groupBox4.Controls.Add(this.restoreFolderTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.backupsListBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(828, 290);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Találatok";
            // 
            // cliToolNameTextBox
            // 
            this.cliToolNameTextBox.Location = new System.Drawing.Point(496, 19);
            this.cliToolNameTextBox.Name = "cliToolNameTextBox";
            this.cliToolNameTextBox.ReadOnly = true;
            this.cliToolNameTextBox.Size = new System.Drawing.Size(308, 20);
            this.cliToolNameTextBox.TabIndex = 17;
            // 
            // journalButton
            // 
            this.journalButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.journalButton.Location = new System.Drawing.Point(496, 121);
            this.journalButton.Name = "journalButton";
            this.journalButton.Size = new System.Drawing.Size(111, 30);
            this.journalButton.TabIndex = 16;
            this.journalButton.Text = "Napló";
            this.journalButton.UseVisualStyleBackColor = false;
            this.journalButton.Click += new System.EventHandler(this.journalButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.LightCoral;
            this.restoreButton.Location = new System.Drawing.Point(496, 217);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(111, 30);
            this.restoreButton.TabIndex = 15;
            this.restoreButton.Text = "Helyreállít";
            this.restoreButton.UseVisualStyleBackColor = false;
            // 
            // incrementalCheckBox
            // 
            this.incrementalCheckBox.AutoSize = true;
            this.incrementalCheckBox.Enabled = false;
            this.incrementalCheckBox.Location = new System.Drawing.Point(496, 46);
            this.incrementalCheckBox.Name = "incrementalCheckBox";
            this.incrementalCheckBox.Size = new System.Drawing.Size(125, 17);
            this.incrementalCheckBox.TabIndex = 10;
            this.incrementalCheckBox.Text = "Inkrementális mentés";
            this.incrementalCheckBox.UseVisualStyleBackColor = true;
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(433, 98);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(57, 13);
            this.targetLabel.TabIndex = 14;
            this.targetLabel.Text = "Cél mappa";
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(496, 95);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.ReadOnly = true;
            this.targetTextBox.Size = new System.Drawing.Size(308, 20);
            this.targetTextBox.TabIndex = 13;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(419, 72);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(71, 13);
            this.sourceLabel.TabIndex = 12;
            this.sourceLabel.Text = "Forrás mappa";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(496, 69);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ReadOnly = true;
            this.sourceTextBox.Size = new System.Drawing.Size(308, 20);
            this.sourceTextBox.TabIndex = 11;
            // 
            // toolLabel
            // 
            this.toolLabel.AutoSize = true;
            this.toolLabel.Location = new System.Drawing.Point(392, 22);
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(98, 13);
            this.toolLabel.TabIndex = 9;
            this.toolLabel.Text = "Parancssori eszköz";
            // 
            // restoreFolderTextBox
            // 
            this.restoreFolderTextBox.Location = new System.Drawing.Point(496, 191);
            this.restoreFolderTextBox.Name = "restoreFolderTextBox";
            this.restoreFolderTextBox.Size = new System.Drawing.Size(308, 20);
            this.restoreFolderTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Helyreállítási mappa";
            // 
            // backupsListBox
            // 
            this.backupsListBox.FormattingEnabled = true;
            this.backupsListBox.Location = new System.Drawing.Point(6, 19);
            this.backupsListBox.Name = "backupsListBox";
            this.backupsListBox.Size = new System.Drawing.Size(359, 264);
            this.backupsListBox.TabIndex = 6;
            this.backupsListBox.SelectedIndexChanged += new System.EventHandler(this.backupsListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.findByTargetButton);
            this.groupBox3.Controls.Add(this.findByTargetBrowseButton);
            this.groupBox3.Controls.Add(this.findByTargetTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 57);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mappa megadásával";
            // 
            // findByTargetButton
            // 
            this.findByTargetButton.Location = new System.Drawing.Point(452, 20);
            this.findByTargetButton.Name = "findByTargetButton";
            this.findByTargetButton.Size = new System.Drawing.Size(75, 23);
            this.findByTargetButton.TabIndex = 4;
            this.findByTargetButton.Text = "Keres";
            this.findByTargetButton.UseVisualStyleBackColor = true;
            this.findByTargetButton.Click += new System.EventHandler(this.findByTargetButton_Click);
            // 
            // findByTargetBrowseButton
            // 
            this.findByTargetBrowseButton.Location = new System.Drawing.Point(371, 20);
            this.findByTargetBrowseButton.Name = "findByTargetBrowseButton";
            this.findByTargetBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.findByTargetBrowseButton.TabIndex = 0;
            this.findByTargetBrowseButton.Text = "Tallóz ...";
            this.findByTargetBrowseButton.UseVisualStyleBackColor = true;
            this.findByTargetBrowseButton.Click += new System.EventHandler(this.findByTargetBrowseButton_Click);
            // 
            // findByTargetTextBox
            // 
            this.findByTargetTextBox.Location = new System.Drawing.Point(105, 22);
            this.findByTargetTextBox.Name = "findByTargetTextBox";
            this.findByTargetTextBox.Size = new System.Drawing.Size(260, 20);
            this.findByTargetTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cél mappa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.findByNameComboBox);
            this.groupBox2.Controls.Add(this.findByNameButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 55);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tárolt mentési beálítás alapján";
            // 
            // findByNameComboBox
            // 
            this.findByNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.findByNameComboBox.FormattingEnabled = true;
            this.findByNameComboBox.Location = new System.Drawing.Point(105, 19);
            this.findByNameComboBox.Name = "findByNameComboBox";
            this.findByNameComboBox.Size = new System.Drawing.Size(260, 21);
            this.findByNameComboBox.TabIndex = 3;
            // 
            // findByNameButton
            // 
            this.findByNameButton.Location = new System.Drawing.Point(371, 18);
            this.findByNameButton.Name = "findByNameButton";
            this.findByNameButton.Size = new System.Drawing.Size(75, 23);
            this.findByNameButton.TabIndex = 2;
            this.findByNameButton.Text = "Keres";
            this.findByNameButton.UseVisualStyleBackColor = true;
            this.findByNameButton.Click += new System.EventHandler(this.findByNameButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // JournalAndRecoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 463);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JournalAndRecoverForm";
            this.Text = "Napló és Helyreállítás";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button findByTargetBrowseButton;
        private System.Windows.Forms.TextBox findByTargetTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button findByNameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox findByNameComboBox;
        private System.Windows.Forms.Button findByTargetButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox backupsListBox;
        private System.Windows.Forms.TextBox restoreFolderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox incrementalCheckBox;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label toolLabel;
        private System.Windows.Forms.Button journalButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.TextBox cliToolNameTextBox;
        private System.Windows.Forms.FolderBrowserDialog targetFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog restoreFolderBrowserDialog;
    }
}