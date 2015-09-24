using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        private readonly BackupSettingsDao backupSettingsDao = BackupSettingsDao.Instance;
        private string reportFile;

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
            
            string targetFolder = GetBackupFolder(BackupSettings);
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }
            backupSettingsDao.SaveBackupSettings(targetFolder, BackupSettings);
            AppendJournalHeader();
            StartProcess(CreateCommand(BackupSettings, targetFolder));
        }

        private void AppendJournalHeader()
        {
            outputRichTextBox.AppendText("# BackDown mentésnapló\n");

            outputRichTextBox.AppendText(string.Format("\n## {0}\n", BackupSettings.Name));

            if (!string.IsNullOrEmpty(Note))
            {
                outputRichTextBox.AppendText(string.Format("\n### {0}\n", Note));
            }
            outputRichTextBox.AppendText(string.Format("\n### Mentési beállítások\n", Note));
            outputRichTextBox.AppendText(string.Format("- Forrás mappa: `{0}`\n", BackupSettings.Source));
            outputRichTextBox.AppendText(string.Format("- Cél mappa: `{0}`\n", BackupSettings.Target));
            outputRichTextBox.AppendText(string.Format("- Inkrementális: {0}\n", BackupSettings.Incremental ? "Igen" : "Nem"));
            outputRichTextBox.AppendText(string.Format("\n### Indítva: {0}\n", startedAt.ToString(CultureInfo.CurrentCulture)));
        }

        private string CreateCommand(BackupSettings settings, string targetFolder)
        {
            string command = settings.Incremental
                ? settings.CliTool.IncrementalBackupCommand
                : settings.CliTool.BackupCommand;

            command = command.Replace(Settings.Default.SOURCE_PLACEHOLDER, String.Format("\"{0}\"", settings.Source));
            command = command.Replace(Settings.Default.TARGET_PLACEHOLDER, String.Format("\"{0}\"", targetFolder));
            return command;
        }

        private void StartProcess(string command)
        {
            outputRichTextBox.AppendText(string.Format("\n### Parancs \n\t{0}\n", command));
            outputRichTextBox.AppendText("\n### Kimenet\n");

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

            Thread.Sleep(500);

            if (process.ExitCode == 0)
            {
                InvokeAppendOutputToTextBox("### A mentés sikeresen befejeződött.");
            }
            else
            {
                InvokeAppendOutputToTextBox("### A mentés során hiba történt.");
            }
            InvokeAppendOutputToTextBox(String.Format("### Eltelet idő: {0}", elapsedTimeTextBox.Text));
            timer.Stop();
            BeginInvoke(new Action(() => SaveReport(GetBackupFolder(BackupSettings))));
        }

        private void SaveReport(string targetFolder)
        {
            string path = String.Format("{0}\\{1}", targetFolder, Settings.Default.JOURNAL_FILE);
            string markdownFile = path + ".md";
            using (StreamWriter writer = new StreamWriter(File.Create(markdownFile), Encoding.Default))
            {
                writer.WriteLine(outputRichTextBox.Text);
            }

            reportFile = path + ".html";
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", string.Format("/C multimarkdown.exe \"{0}.md\" > \"{1}\"", path, reportFile));
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(psi).WaitForExit();
            File.Delete(markdownFile);

            showReportButton.Enabled = true;
        }

        private void InvokeAppendOutputToTextBox(string line)
        {
            Invoke(new Action(() => outputRichTextBox.AppendText(string.Format("{0}\n", line))));
        }

        private void ProcessOnErrorDataReceived(object sender, DataReceivedEventArgs dataReceivedEventArgs)
        {
            InvokeAppendOutputToTextBox(string.Format("\t{0}", dataReceivedEventArgs.Data));
        }

        private void ProcessOnOutputDataReceived(object sender, DataReceivedEventArgs dataReceivedEventArgs)
        {
            InvokeAppendOutputToTextBox(string.Format("\t{0}", dataReceivedEventArgs.Data));
        }

        public string GetBackupFolder(BackupSettings settings)
        {
            string targetFolder = settings.Incremental
                ? String.Format("{0}\\{1}", settings.Target, settings.Name) :
                String.Format("{0}\\{1}_{2}", settings.Target, settings.Name, startedAt.ToString("yyyy-MM-dd_HHmmss"));
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

        private void showReportButton_Click(object sender, EventArgs e)
        {
            Process.Start(reportFile);
        }
    }
}
