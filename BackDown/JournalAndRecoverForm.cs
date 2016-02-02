using System;
using System.Diagnostics;
using System.IO;
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
            journalButton.Enabled = false;
            restoreButton.Enabled = false;
        }

        private void findByTargetButton_Click(object sender, EventArgs e)
        {
            ClearResultControls();
            if (string.IsNullOrEmpty(findByTargetTextBox.Text))
            {
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
            cliToolNameTextBox.Text = "";
            restoreFolderTextBox.Text = "";
        }

        private void findByNameButton_Click(object sender, EventArgs e)
        {
            BackupSettings backupSettings = findByNameComboBox.SelectedItem as BackupSettings;
            ClearResultControls();
            if (backupSettings == null)
            {
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
            bool isSelected = backupsListBox.SelectedIndex >= 0;
            
            journalButton.Enabled = isSelected;
            restoreButton.Enabled = isSelected;

            if (!isSelected)
            {
                ClearResultControls();
                return;
            }
            BackupSettings settings = ((Backup) backupsListBox.SelectedItem).BackupSettings;
            cliToolNameTextBox.Text = settings.CliToolName;
            sourceTextBox.Text = settings.Source;
            targetTextBox.Text = settings.Target;
            restoreFolderTextBox.Text = sourceTextBox.Text;
        }

        private void journalButton_Click(object sender, EventArgs e)
        {
            try
            {
                Backup backup = (Backup) backupsListBox.SelectedItem;
                Process.Start(string.Format("{0}\\{1}\\{2}.html", backup.BackupSettings.Target, backup.BackupFolderName,
                    Settings.Default.BACKUP_JOURNAL_FILE));
            }
            catch (Exception)
            {
                MessageBox.Show(this, "A kiválasztott mentéshez nem található napló.");
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            Backup backup = (Backup)backupsListBox.SelectedItem;
            RestoreSettings restoreSettings = new RestoreSettings();
            restoreSettings.CliTool = backup.BackupSettings.CliTool;
            restoreSettings.BackupFolder = backup.BackupSettings.Target + "\\" + backup.BackupFolderName;
            restoreSettings.RestoreFolder = restoreFolderTextBox.Text;
            restoreSettings.Name = backup.BackupSettings.Name;

            if (Directory.Exists(restoreSettings.RestoreFolder) &&
                Directory.GetFileSystemEntries(restoreSettings.RestoreFolder).Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show(this,
                    "A kiválasztott helyreállítási mappa nem üres.\n" +
                    "A helyreállítás során a mappában található fájlok felülíródnak, így adatvesztés következhet be.\n\n" +
                    "Megerősít?",
                    "Biztos benne?", MessageBoxButtons.YesNo);
                if (DialogResult.Yes != dialogResult)
                {
                    return;
                }
            }

            RestoreForm restoreForm = new RestoreForm();
            restoreForm.RestoreSettings = restoreSettings;
            restoreForm.ShowDialog(this);
        }

        private void restoreFolderTextBox_Enter(object sender, EventArgs e)
        {
            restoreFolderBrowserDialog.SelectedPath = restoreFolderTextBox.Text;
            if (DialogResult.OK == restoreFolderBrowserDialog.ShowDialog(this))
            {
                restoreFolderTextBox.Text = restoreFolderBrowserDialog.SelectedPath;
            }
        }
    }
}
