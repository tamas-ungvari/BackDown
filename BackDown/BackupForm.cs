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
            timer.Start();
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
            var targetFolder = GetBackupFolder(BackupSettings);
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }
            command = command.Replace(Settings.Default.TARGET_PLACEHOLDER, String.Format("\"{0}\"", targetFolder));

            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            int spaceIndex = command.IndexOf(" ");
            process.StartInfo.FileName = command.Substring(0, spaceIndex);
            process.StartInfo.Arguments = command.Substring(spaceIndex + 1);
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.EnableRaisingEvents = true;
            process.OutputDataReceived += ProcessOnOutputDataReceived;
            process.ErrorDataReceived += ProcessOnErrorDataReceived;
            process.Exited += ProcessOnExited;
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        private void ProcessOnExited(object sender, EventArgs eventArgs)
        {
            Process process = sender as Process;
            if (process.ExitCode == 0)
            {
                InvokeAppendToTextBox("A mentés sikeresen befejeződött.");
            }
            else
            {
                InvokeAppendToTextBox("A mentés során hiba történt.");
            }
            InvokeAppendToTextBox(String.Format("Eltelet idő: {0}", elapsedTimeTextBox.Text));
            timer.Stop();
        }

        private void InvokeAppendToTextBox(string line)
        {
            BeginInvoke(new Action(() => outputRichTextBox.AppendText((line + "\n"))));
        }

        private void ProcessOnErrorDataReceived(object sender, DataReceivedEventArgs dataReceivedEventArgs)
        {
            InvokeAppendToTextBox(dataReceivedEventArgs.Data);
        }

        private void ProcessOnOutputDataReceived(object sender, DataReceivedEventArgs dataReceivedEventArgs)
        {
            InvokeAppendToTextBox(dataReceivedEventArgs.Data);
        }

        public string GetBackupFolder(BackupSettings settings)
        {
            string targetFolder = settings.Incremental
                ? String.Format("{0}\\{1}", settings.Target, settings.Name) :
                String.Format("{0}\\{1} {2}", settings.Target, settings.Name, DateTime.Now.ToShortDateString());
            return targetFolder;
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
