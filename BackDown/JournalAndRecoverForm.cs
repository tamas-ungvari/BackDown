using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackDown.Properties;

namespace BackDown
{
    public partial class JournalAndRecoverForm : Form
    {
        readonly BackupSettingsDao backupSettingsDao = BackupSettingsDao.Instance;

        public JournalAndRecoverForm()
        {
            InitializeComponent();
            findByNameComboBox.DataSource = backupSettingsDao.LoadBackupSettingsList();
            findByNameComboBox.DisplayMember = "Name";
            findByNameComboBox.SelectedIndex = -1;
            backupsListBox.DisplayMember = "Name";
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
                backupsListBox.Items.Add(backupSettings);
                
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
            BackupSettings settings = backupsListBox.SelectedItem as BackupSettings;
            cliToolNameTextBox.Text = settings.CliToolName;
            sourceTextBox.Text = settings.Source;
            targetTextBox.Text = settings.Target;
            incrementalCheckBox.Checked = settings.Incremental;
            restoreFolderTextBox.Text = sourceTextBox.Text;
        }
    }
}
