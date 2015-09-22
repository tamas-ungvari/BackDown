using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BackDown.Properties;

namespace BackDown
{
    public partial class CliToolForm : Form
    {
        string sourcePlaceholder = Settings.Default.SOURCE_PLACEHOLDER;
        string targetPlaceholder = Settings.Default.TARGET_PLACEHOLDER;

        private BindingSource bindingSource;

        public BindingSource BindingSource
        {
            get { return bindingSource; }
            set { 
                bindingSource = value;
                textBoxCliToolName.DataBindings.Add("Text", bindingSource, "name");
                textBoxBackupCommand.DataBindings.Add("Text", bindingSource, "backupCommand");
                textBoxIncrementalBackupCommand.DataBindings.Add("Text", bindingSource, "incrementalBackupCommand");
                textBoxRestoreCommand.DataBindings.Add("Text", bindingSource, "restoreCommand");
            }
        }

        private CliToolDao cliToolsDao = CliToolDao.Instance;

        public CliToolForm()
        {
            InitializeComponent();
            sourcePlaceholderLabel.Text += sourcePlaceholder;
            targetPlaceholderLabel.Text += targetPlaceholder;
            string fileFilterText = "JSON files (.json)|*.json";
            saveFileDialog.Filter = fileFilterText;
            saveFileDialog.RestoreDirectory = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            bool incrementalBackupCommandEmpty = string.IsNullOrEmpty(textBoxIncrementalBackupCommand.Text);
            
            if (ValidateChildren())
            {
                (bindingSource.Current as CliTool).IncrementalBackupEnabled = !incrementalBackupCommandEmpty;
            }
            else
            {
                DialogResult = DialogResult.None;
            }

        }

        private void textBoxBackupCommand_Validating(object sender, CancelEventArgs e)
        {
            bool containsSourceAndTarget = ContainsSourceAndTarget(textBoxBackupCommand.Text);
            e.Cancel = string.IsNullOrEmpty(textBoxBackupCommand.Text) || !containsSourceAndTarget;
            if (e.Cancel)
            {
                textBoxBackupCommand.Focus();
                groupBoxBackup.ForeColor = Color.Red;
                MessageBox.Show("A mentés parancs nem lehet üres és tartalmaznia kell a forrás és cél referenciákat.");
            }
            else
            {
                groupBoxBackup.ForeColor = Color.Black;
            }
        }

        private bool ContainsSourceAndTarget(string text)
        {
            return text.Contains(sourcePlaceholder) && text.Contains(targetPlaceholder);
        }

        private void textBoxCliToolName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(textBoxCliToolName.Text);
            if (e.Cancel)
            {
                textBoxCliToolName.Focus();
                labelCliToolName.ForeColor = Color.Red;
                MessageBox.Show("Az eszköz neve nem lehet üres");
            }
            else 
            {
                labelCliToolName.ForeColor = Color.Black;
            }
        }

        private void textBoxRestoreCommand_Validating(object sender, CancelEventArgs e)
        {
            bool containsSourceAndTarget = ContainsSourceAndTarget(textBoxRestoreCommand.Text);
            e.Cancel = string.IsNullOrEmpty(textBoxRestoreCommand.Text) || !containsSourceAndTarget;
            if (e.Cancel)
            {
                textBoxRestoreCommand.Focus();
                groupBoxRestore.ForeColor = Color.Red;
                MessageBox.Show("A helyreállítás parancs nem lehet üres és tartalmaznia kell a forrás és cél referenciákat.");
            }
            else
            {
                groupBoxRestore.ForeColor = Color.Black;
            }
        }

        private void textBoxIncrementalBackupCommand_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxIncrementalBackupCommand.Text.Length > 0)
            {
                e.Cancel = !ContainsSourceAndTarget(textBoxIncrementalBackupCommand.Text);
            }
            if (e.Cancel)
            {
                textBoxIncrementalBackupCommand.Focus();
                groupBoxIncrementalBackup.ForeColor = Color.Red;
                MessageBox.Show("Az inkrementális mentés parancs ha nem üres, tartalmaznia kell a forrás és cél referenciákat.");
            }
            else
            {
                groupBoxIncrementalBackup.ForeColor = Color.Black;
            }

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream stream;
                    if ((stream = saveFileDialog.OpenFile()) != null)
                    {
                        cliToolsDao.WriteToStream(stream, bindingSource.Current as CliTool);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Az import fájl nem írható.");
                }
            }
        }
    }
}
