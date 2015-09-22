namespace BackDown
{
    partial class BackupForm
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
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.incrementalCheckBox = new System.Windows.Forms.CheckBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.toolLabel = new System.Windows.Forms.Label();
            this.cliToolTextBox = new System.Windows.Forms.TextBox();
            this.startedAtLabel = new System.Windows.Forms.Label();
            this.startAtTextBox = new System.Windows.Forms.TextBox();
            this.elapsedTimeTextBox = new System.Windows.Forms.TextBox();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputRichTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputRichTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.outputRichTextBox.Location = new System.Drawing.Point(12, 100);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(836, 536);
            this.outputRichTextBox.TabIndex = 0;
            this.outputRichTextBox.Text = "";
            // 
            // incrementalCheckBox
            // 
            this.incrementalCheckBox.AutoSize = true;
            this.incrementalCheckBox.Enabled = false;
            this.incrementalCheckBox.Location = new System.Drawing.Point(513, 64);
            this.incrementalCheckBox.Name = "incrementalCheckBox";
            this.incrementalCheckBox.Size = new System.Drawing.Size(125, 17);
            this.incrementalCheckBox.TabIndex = 10;
            this.incrementalCheckBox.Text = "Inkrementális mentés";
            this.incrementalCheckBox.UseVisualStyleBackColor = true;
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(450, 41);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(57, 13);
            this.targetLabel.TabIndex = 14;
            this.targetLabel.Text = "Cél mappa";
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(513, 38);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.ReadOnly = true;
            this.targetTextBox.Size = new System.Drawing.Size(335, 20);
            this.targetTextBox.TabIndex = 13;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(436, 15);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(71, 13);
            this.sourceLabel.TabIndex = 12;
            this.sourceLabel.Text = "Forrás mappa";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(513, 12);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ReadOnly = true;
            this.sourceTextBox.Size = new System.Drawing.Size(335, 20);
            this.sourceTextBox.TabIndex = 11;
            // 
            // toolLabel
            // 
            this.toolLabel.AutoSize = true;
            this.toolLabel.Location = new System.Drawing.Point(12, 15);
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(107, 13);
            this.toolLabel.TabIndex = 9;
            this.toolLabel.Text = "Parancssoros eszköz";
            // 
            // cliToolTextBox
            // 
            this.cliToolTextBox.Location = new System.Drawing.Point(125, 12);
            this.cliToolTextBox.Name = "cliToolTextBox";
            this.cliToolTextBox.ReadOnly = true;
            this.cliToolTextBox.Size = new System.Drawing.Size(292, 20);
            this.cliToolTextBox.TabIndex = 15;
            // 
            // startedAtLabel
            // 
            this.startedAtLabel.AutoSize = true;
            this.startedAtLabel.Location = new System.Drawing.Point(78, 67);
            this.startedAtLabel.Name = "startedAtLabel";
            this.startedAtLabel.Size = new System.Drawing.Size(41, 13);
            this.startedAtLabel.TabIndex = 16;
            this.startedAtLabel.Text = "Indítva";
            // 
            // startAtTextBox
            // 
            this.startAtTextBox.Location = new System.Drawing.Point(125, 64);
            this.startAtTextBox.Name = "startAtTextBox";
            this.startAtTextBox.ReadOnly = true;
            this.startAtTextBox.Size = new System.Drawing.Size(122, 20);
            this.startAtTextBox.TabIndex = 17;
            // 
            // elapsedTimeTextBox
            // 
            this.elapsedTimeTextBox.Location = new System.Drawing.Point(306, 64);
            this.elapsedTimeTextBox.Name = "elapsedTimeTextBox";
            this.elapsedTimeTextBox.ReadOnly = true;
            this.elapsedTimeTextBox.Size = new System.Drawing.Size(111, 20);
            this.elapsedTimeTextBox.TabIndex = 19;
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(253, 67);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(47, 13);
            this.elapsedTimeLabel.TabIndex = 18;
            this.elapsedTimeLabel.Text = "Eltelt idő";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(125, 38);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ReadOnly = true;
            this.noteTextBox.Size = new System.Drawing.Size(292, 20);
            this.noteTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Megjegyzés";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 648);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.elapsedTimeTextBox);
            this.Controls.Add(this.elapsedTimeLabel);
            this.Controls.Add(this.startAtTextBox);
            this.Controls.Add(this.startedAtLabel);
            this.Controls.Add(this.cliToolTextBox);
            this.Controls.Add(this.incrementalCheckBox);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.toolLabel);
            this.Controls.Add(this.outputRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupForm";
            this.Text = "Mentési folyamat";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.CheckBox incrementalCheckBox;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label toolLabel;
        private System.Windows.Forms.TextBox cliToolTextBox;
        private System.Windows.Forms.Label startedAtLabel;
        private System.Windows.Forms.TextBox startAtTextBox;
        private System.Windows.Forms.TextBox elapsedTimeTextBox;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer;
    }
}