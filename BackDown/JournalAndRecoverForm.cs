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
    struct Backup
    {
        public string BackupFolderName { get; set; }
        public BackupSettings BackupSettings { get; set; }
    }

    public partial class JournalAndRecoverForm : Form
    {
        readonly BackupSettingsDao backupSettingsDao = BackupSettingsDao.Instance;

        public JournalAndRecoverForm()
        {
            InitializeComponent();
            findByNameComboBox.DataSource = backupSettingsDao.LoadBackupSettingsList();
            findByNameComboBox.DisplayMember = "Name";
            findByNameComboBox.SelectedIndex = -1;
            backupsListBox.DisplayMember = "BackupFolderName";
        }

        private void findByTargetButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(findByTargetTextBox.Text))
            {
                ClearResultControls();
                return;
            }
            FindBackupsByTarget(findByTargetTextBox.Text);
        }

        private void FindBackupsByTarget(string target)
        {
            if (!Directory.Exists(target))
            {
                ClearResultControls();
                return;
            }
            foreach (string directory in Directory.EnumerateDirectories(target))
            {
                BackupSettings backupSettings = backupSettingsDao.LoadBackupSettings(directory);
                if (backupSettings == null)
                {
                    continue;
                }
                backupsListBox.Items.Add(new Backup
                {
                    BackupSettings = backupSettings,
                    BackupFolderName = Path.GetFileName(directory)
                });                
            }
        }

        private void ClearResultControls()
        {
            backupsListBox.Items.Clear();
            sourceTextBox.Text = "";
            targetTextBox.Text = "";
            incrementalCheckBox.Text = "";
            cliToolNameTextBox.Text = "";
            restoreFolderTextBox.Text = "";
        }

        private void findByNameButton_Click(object sender, EventArgs e)
        {
            BackupSettings backupSettings = findByNameComboBox.SelectedItem as BackupSettings;
            if (backupSettings == null)
            {
                ClearResultControls();
                return;
            }
            FindBackupsByTarget(backupSettings.Target);
        }

        private void findByTargetBrowseButton_Click(object sender, EventArgs e)
        {
            targetFolderBrowserDialog.SelectedPath = findByTargetTextBox.Text;
            if (DialogResult.OK == targetFolderBrowserDialog.ShowDialog(this))
            {
                findByTargetTextBox.Text = targetFolderBrowserDialog.SelectedPath;
            }
        }

        private void backupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (backupsListBox.SelectedIndex < 0)
            {
                ClearResultControls();
                return;
            }
            BackupSettings settings = ((Backup) backupsListBox.SelectedItem).BackupSettings;
            cliToolNameTextBox.Text = settings.CliToolName;
            sourceTextBox.Text = settings.Source;
            targetTextBox.Text = settings.Target;
            incrementalCheckBox.Checked = settings.Incremental;
            restoreFolderTextBox.Text = sourceTextBox.Text;
        }

        private void journalButton_Click(object sender, EventArgs e)
        {
            try
            {
                Backup backup = (Backup) backupsListBox.SelectedItem;
                Process.Start(string.Format("{0}\\{1}\\{2}.html", backup.BackupSettings.Target, backup.BackupFolderName,
                    Settings.Default.JOURNAL_FILE));
            }
            catch (Exception)
            {
                MessageBox.Show(this, "A kiválasztott mentéshez nem található napló.");
            }
        }
    }
}
