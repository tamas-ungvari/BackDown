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
        readonly CliToolDao cliToolsDao = CliToolDao.Instance;
        readonly  BackupSettingsDao backupSettingsDao = BackupSettingsDao.Instance;

        public BackupManagerForm()
        {
            InitializeComponent();
            backupSettingsPicker.BindingSource.CurrentChanged += backupSettingsBindingSource_CurrentChanged;
            cliToolComboBox.DataSource = cliToolsDao.LoadListFromFile();
            cliToolComboBox.DisplayMember = "Name";
        }

        private void cliToolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CliTool cliTool = cliToolComboBox.SelectedItem as CliTool;
            if (cliTool == null)
            {
                incrementalCheckBox.Enabled = false;
                incrementalCheckBox.Checked = false;
            }
            else
            {
                incrementalCheckBox.Enabled = cliTool.IncrementalBackupEnabled;
                incrementalCheckBox.Checked &= cliTool.IncrementalBackupEnabled;
            }
        }

        private void browseSourceButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sourceTextBox.Text))
            {
                sourceFolderBrowserDialog.SelectedPath = sourceTextBox.Text;
            }
            if (DialogResult.OK == sourceFolderBrowserDialog.ShowDialog(this))
            {
                sourceTextBox.Text = sourceFolderBrowserDialog.SelectedPath;
                sourceTextBox.Focus();
                sourceLabel.ForeColor = Color.Green;
            }
        }

        private void browseTargetButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(targetTextBox.Text))
            {
                targetFolderBrowserDialog.SelectedPath = targetTextBox.Text;
            }
            if (DialogResult.OK == targetFolderBrowserDialog.ShowDialog(this))
            {
                targetTextBox.Text = targetFolderBrowserDialog.SelectedPath;
                targetTextBox.Focus();
                targetLabel.ForeColor = Color.Green;
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
                BackupForm backupForm = new BackupForm();
                backupForm.BackupSettings = CreateBackupSettingsFromControls();
                backupForm.Note = noteTextBox.Text;
                backupForm.ShowDialog(this);
            }
        }

        private BackupSettings CreateBackupSettingsFromControls()
        {
            BackupSettings backupSettings = new BackupSettings();
            backupSettings.CliTool = cliToolComboBox.SelectedItem as CliTool;
            backupSettings.Name = saveAsNameTextBox.Text;
            backupSettings.Incremental = incrementalCheckBox.Checked;
            backupSettings.Source = sourceTextBox.Text;
            backupSettings.Target = targetTextBox.Text;
            return backupSettings;
        }

        private bool ValidateBackupSettingsForm()
        {
            bool nameIsValid = !string.IsNullOrEmpty(saveAsNameTextBox.Text);
            if (!nameIsValid)
            {
                saveAsNameLabel.ForeColor = Color.Red;
                saveAsNameTextBox.Focus();
                MessageBox.Show(this, "Csak név megadásával lehet a mentési konfigurációt eltárolni.");
                return false;
            }
            saveAsNameLabel.ForeColor = SystemColors.ControlText;

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
                toolLabel.ForeColor = SystemColors.ControlText;
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
                sourceLabel.ForeColor = SystemColors.ControlText;
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
                targetLabel.ForeColor = SystemColors.ControlText;
            }

            return true;
        }

        private void saveBackupSettingsButton_Click(object sender, EventArgs e)
        {
            if (!ValidateBackupSettingsForm())
            {
                return;
            }

            SaveBackupSettings();
        }

        private void SaveBackupSettings()
        {
            BackupSettings backupSettings = CreateBackupSettingsFromControls();

            bool edit = false;
            BindingSource bindingSource = backupSettingsPicker.BindingSource;
            List<BackupSettings> list =  bindingSource.List as List<BackupSettings>;
            foreach (BackupSettings settings in list)
            {
                if (settings.Name.Equals(backupSettings.Name))
                {
                    edit = true;
                    settings.CliTool = backupSettings.CliTool;
                    settings.Incremental = backupSettings.Incremental;
                    settings.Source = backupSettings.Source;
                    settings.Target = backupSettings.Target;
                    break;
                }
            }

            if (!edit)
            {
                bindingSource.Add(backupSettings);
                backupSettingsDao.SaveBackupSettingsList(bindingSource.DataSource as List<BackupSettings>);
                backupSettingsPicker.BindingSource.MoveLast();
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "Biztos benne, hogy felül szeretné írni a korábbi beállítást?", 
                    "Már létezik beállítás ezen a néven", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    backupSettingsDao.SaveBackupSettingsList(bindingSource.DataSource as List<BackupSettings>);
                    cliToolComboBox.DataSource = cliToolsDao.LoadListFromFile();
                }
            }

            ResetLabelColors();
        }

        private void deleteBackupSettingsButton_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = backupSettingsPicker.BindingSource;
            bindingSource.RemoveCurrent();
            bindingSource.Position = -1;
            backupSettingsDao.SaveBackupSettingsList(bindingSource.DataSource as List<BackupSettings>);
        }

        private void newBackupSettingsButton_Click(object sender, EventArgs e)
        {
            cliToolComboBox.SelectedIndex = -1;
            incrementalCheckBox.Checked = false;
            sourceTextBox.Text = "";
            targetTextBox.Text = "";
            noteTextBox.Text = "";
            saveAsNameTextBox.Text = "";
        }

        private void sourceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            sourceLabel.ForeColor = Color.Green;
        }

        private void targetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            targetLabel.ForeColor = Color.Green;
        }

        private void saveAsNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            saveAsNameLabel.ForeColor = Color.Green;
        }

        private void incrementalCheckBox_Click(object sender, EventArgs e)
        {
            incrementalCheckBox.ForeColor = Color.Green;
        }

        private void ResetLabelColors()
        {
            sourceLabel.ForeColor = SystemColors.ControlText;
            targetLabel.ForeColor = SystemColors.ControlText;
            saveAsNameLabel.ForeColor = SystemColors.ControlText;
            incrementalCheckBox.ForeColor = SystemColors.ControlText;
            toolLabel.ForeColor = SystemColors.ControlText;
        }

        private void backupSettingsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ResetLabelColors();
            BackupSettings settings = backupSettingsPicker.BindingSource.Current as BackupSettings;
            if (settings == null || string.IsNullOrEmpty(settings.Name))
            {
                return;
            }
            deleteBackupSettingsButton.Enabled = true;
            cliToolComboBox.SelectedItem = settings.CliTool;
            incrementalCheckBox.Checked = settings.Incremental;
            sourceTextBox.Text = settings.Source;
            targetTextBox.Text = settings.Target;
            saveAsNameTextBox.Text = settings.Name;
        }

    }
}
