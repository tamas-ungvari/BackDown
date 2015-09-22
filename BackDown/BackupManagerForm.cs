using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackDown
{
    public partial class BackupManagerForm : Form
    {
        CliToolDao cliToolsDao = CliToolDao.Instance;
        BackupSettingsDao backupSettingsDao = BackupSettingsDao.Instance;

        public BackupManagerForm()
        {
            InitializeComponent();
            cliToolComboBox.DataSource = cliToolsDao.LoadListFromFile();
            cliToolComboBox.DisplayMember = "Name";
            backupSettingsBindingSource.DataSource = backupSettingsDao.LoadBackupSettingsList();
        }

        private void cliToolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CliTool cliTool = cliToolComboBox.SelectedItem as CliTool;
            incrementalCheckBox.Enabled = cliTool.IncrementalBackupEnabled;
            incrementalCheckBox.Checked &= cliTool.IncrementalBackupEnabled;
        }

        private void browseSourceButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == sourceFolderBrowserDialog.ShowDialog(this))
            {
                sourceTextBox.Text = sourceFolderBrowserDialog.SelectedPath;
            }
        }

        private void browseTargetButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == targetFolderBrowserDialog.ShowDialog(this))
            {
                targetTextBox.Text = targetFolderBrowserDialog.SelectedPath;
            }
        }

        private void startBackupButton_Click(object sender, EventArgs e)
        {
            bool valid = ValidateBackupSettingsForm();

            if (!valid)
            {
                return;
            }
            else
            {
            }
        }

        private bool ValidateBackupSettingsForm()
        {
            bool toolIsValid = cliToolComboBox.SelectedIndex > -1;
            if (!toolIsValid)
            {
                toolLabel.ForeColor = Color.Red;
                cliToolComboBox.Focus();
                MessageBox.Show(this, "Nincs kiválsztott eszköz.");
                return false;
            }
            else
            {
                toolLabel.ForeColor = Color.Black;
            }
            bool sourceIsValid = !string.IsNullOrEmpty(sourceTextBox.Text);
            if (!sourceIsValid)
            {
                sourceLabel.ForeColor = Color.Red;
                sourceTextBox.Focus();
                MessageBox.Show(this, "A forrás mappa mező nem lehet üres.");
                return false;
            }
            sourceIsValid = Directory.Exists(sourceTextBox.Text);
            if (!sourceIsValid)
            {
                sourceLabel.ForeColor = Color.Red;
                sourceTextBox.Focus();
                MessageBox.Show(this, "A forrás mappa csak egy, már létező mappa lehet.");
                return false;
            }
            else
            {
                sourceLabel.ForeColor = Color.Black;
            }

            bool targetIsValid = !string.IsNullOrEmpty(targetTextBox.Text);
            if (!targetIsValid)
            {
                targetLabel.ForeColor = Color.Red;
                targetTextBox.Focus();
                MessageBox.Show(this, "A cél mappa mező nem lehet üres.");
                return false;
            }
            targetIsValid = Directory.Exists(targetTextBox.Text);
            if (!targetIsValid)
            {
                targetLabel.ForeColor = Color.Red;
                targetTextBox.Focus();
                MessageBox.Show(this, "A cél mappa csak egy, már létező mappa lehet.");
                return false;
            }
            targetIsValid = !sourceTextBox.Text.Equals(targetTextBox.Text);
            if (!targetIsValid)
            {
                targetLabel.ForeColor = Color.Red;
                targetTextBox.Focus();
                MessageBox.Show(this, "A cél mappa nem lehet azonos a forrás mappával.");
                return false;
            }
            else
            {
                targetLabel.ForeColor = Color.Black;
            }

            return true;
        }

        private void saveBackupSettingsButton_Click(object sender, EventArgs e)
        {
            bool valid = ValidateBackupSettingsForm();

            if (!valid)
            {
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(saveAsNameTextBox.Text))
                {
                    saveAsNameLabel.ForeColor = Color.Red;
                    saveAsNameTextBox.Focus();
                    MessageBox.Show(this, "Csak név megadásával lehet a mentési konfigurációt eltárolni.");
                    return;
                }
                else
                {
                    saveAsNameLabel.ForeColor = Color.Black;
                }
            }            

            saveAsNameLabel.ForeColor = Color.Black;
            SaveBackupSettings();
        }

        private void CheckNameUnique()
        {
            BackupSettings current = backupSettingsBindingSource.Current as BackupSettings;
            foreach (BackupSettings backupSettings in backupSettingsBindingSource.List)
            {
                if (backupSettings != current && backupSettings.Name.Equals(current.Name))
                {
                    NewNameForm formNewName = new NewNameForm();
                    formNewName.nameTextBox.Text = current.Name;
                    DialogResult dialogResult = DialogResult.Cancel;
                    while (backupSettings.Name.Equals(current.Name))
                    {
                        MessageBox.Show("Már létezik a rendszerben mentési beállítás a megadott névvel. Kérem adjon meg egy új nevet.");

                        dialogResult = formNewName.ShowDialog(this);
                        if (dialogResult == DialogResult.OK)
                        {
                            current.Name = formNewName.nameTextBox.Text;
                        }
                    }
                    backupSettingsDataGridView.Refresh();
                    CheckNameUnique();
                    break;
                }
            }
        }

        private void SaveBackupSettings()
        {
            BackupSettings backupSettings = new BackupSettings();
            backupSettings.Name = saveAsNameTextBox.Text;
            backupSettings.Source = sourceTextBox.Text;
            backupSettings.Target = targetTextBox.Text;
            backupSettings.Incremental = incrementalCheckBox.Checked;

            backupSettingsBindingSource.Add(backupSettings);
            CheckNameUnique();
            backupSettingsDao.SaveBackupSettingsList(backupSettingsBindingSource.DataSource as List<BackupSettings>);
            backupSettingsDataGridView.Refresh();
        }

        private void deleteBackupSettingsButton_Click(object sender, EventArgs e)
        {
            backupSettingsBindingSource.RemoveCurrent();
            backupSettingsDataGridView.Refresh();
            backupSettingsDao.SaveBackupSettingsList(backupSettingsBindingSource.DataSource as List<BackupSettings>);
        }

        private void backupSettingsDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            deleteBackupSettingsButton.Enabled = false;
            journalButton.Enabled = false;
        }

        private void backupSettingsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            deleteBackupSettingsButton.Enabled = true;
            journalButton.Enabled = true;
        }
    }
}
