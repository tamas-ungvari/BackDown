using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackDown.Properties;

namespace BackDown
{
    public partial class BackupForm : Form
    {
        public BackupSettings BackupSettings { get; set; }
        public string Note { get; set; }

        private DateTime startedAt = DateTime.Now;

        public BackupForm()
        {
            InitializeComponent();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            cliToolTextBox.Text = BackupSettings.CliToolName;
            incrementalCheckBox.Checked = BackupSettings.Incremental;
            sourceTextBox.Text = BackupSettings.Source;
            targetTextBox.Text = BackupSettings.Target;
            noteTextBox.Text = Note;
            startAtTextBox.Text = startedAt.ToString();

            string command = BackupSettings.Incremental
                ? BackupSettings.CliTool.IncrementalBackupCommand
                : BackupSettings.CliTool.BackupCommand;

            command = command.Replace(Settings.Default.SOURCE_PLACEHOLDER, String.Format("\"{0}\"", BackupSettings.Source));
            string targetFolder = String.Format("\"{0}\\{1}\"", BackupSettings.Target, DateTime.Now.ToShortDateString());
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(String.Format("{0}\\{1}", BackupSettings.Target, DateTime.Now.ToShortDateString()));
            }
            command = command.Replace(Settings.Default.TARGET_PLACEHOLDER, targetFolder);

            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            int spaceIndex = command.IndexOf(" ");
            process.StartInfo.FileName = command.Substring(0, spaceIndex);
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = command.Substring(spaceIndex + 1);
            process.Start();
            string line = null;
            while ((line = process.StandardOutput.ReadLine()) != null)
            {
                outputRichTextBox.Text += (line + "\n");
            }
            if (process.ExitCode != 0)
            {
                outputRichTextBox.Text += process.StandardError.ReadToEnd();
            }
            timer.Stop();
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = now - startedAt;
            StringBuilder sb = new StringBuilder();
            if (timeSpan.Hours > 0)
            {
                sb.AppendFormat("{0} óra ", timeSpan.Hours);
            }
            if (timeSpan.Minutes > 0)
            {
                sb.AppendFormat("{0} perc ", timeSpan.Minutes);
            }
            sb.AppendFormat("{0} mp", timeSpan.Seconds);

            string elapsedTime = sb.ToString();
            elapsedTimeTextBox.Text = elapsedTime;
        }
    }
}
