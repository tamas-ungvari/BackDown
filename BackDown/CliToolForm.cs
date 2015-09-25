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
        private BindingSource bindingSource;

        public BindingSource BindingSource
        {
            get { return bindingSource; }
            set { 
                bindingSource = value;
                cliToolNameTextBox.DataBindings.Add("Text", bindingSource, "name");
                backupCommandTextBox.DataBindings.Add("Text", bindingSource, "backupCommand");
                incrementalBackupCommandTextBox.DataBindings.Add("Text", bindingSource, "incrementalBackupCommand");
                restoreCommandTextBox.DataBindings.Add("Text", bindingSource, "restoreCommand");
            }
        }

        private CliToolDao cliToolsDao = CliToolDao.Instance;

        public CliToolForm()
        {
            InitializeComponent();
            sourcePlaceholderLabel.Text += Settings.Default.SOURCE_PLACEHOLDER;
            targetPlaceholderLabel.Text += Settings.Default.TARGET_PLACEHOLDER;
            string fileFilterText = "JSON files (.json)|*.json";
            saveFileDialog.Filter = fileFilterText;
            saveFileDialog.RestoreDirectory = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            bool incrementalBackupCommandEmpty = string.IsNullOrEmpty(incrementalBackupCommandTextBox.Text);
            
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
            bool containsSourceAndTarget = ContainsSourceAndTarget(backupCommandTextBox.Text);
            e.Cancel = string.IsNullOrEmpty(backupCommandTextBox.Text) || !containsSourceAndTarget;
            if (e.Cancel)
            {
                backupCommandTextBox.Focus();
                backupGroupBox.ForeColor = Color.Red;
                MessageBox.Show("A mentés parancs nem lehet üres és tartalmaznia kell a forrás és cél referenciákat.");
            }
            else
            {
                backupGroupBox.ForeColor = Color.Black;
            }
        }

        private bool ContainsSourceAndTarget(string text)
        {
            return text.Contains(Settings.Default.SOURCE_PLACEHOLDER) && text.Contains(Settings.Default.TARGET_PLACEHOLDER);
        }

        private void textBoxCliToolName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(cliToolNameTextBox.Text);
            if (e.Cancel)
            {
                cliToolNameTextBox.Focus();
                cliToolNameLabel.ForeColor = Color.Red;
                MessageBox.Show("Az eszköz neve nem lehet üres");
            }
            else 
            {
                cliToolNameLabel.ForeColor = Color.Black;
            }
        }

        private void textBoxRestoreCommand_Validating(object sender, CancelEventArgs e)
        {
            bool containsSourceAndTarget = ContainsSourceAndTarget(restoreCommandTextBox.Text);
            e.Cancel = string.IsNullOrEmpty(restoreCommandTextBox.Text) || !containsSourceAndTarget;
            if (e.Cancel)
            {
                restoreCommandTextBox.Focus();
                restoreGroupBox.ForeColor = Color.Red;
                MessageBox.Show("A helyreállítás parancs nem lehet üres és tartalmaznia kell a forrás és cél referenciákat.");
            }
            else
            {
                restoreGroupBox.ForeColor = Color.Black;
            }
        }

        private void textBoxIncrementalBackupCommand_Validating(object sender, CancelEventArgs e)
        {
            if (incrementalBackupCommandTextBox.Text.Length > 0)
            {
                e.Cancel = !ContainsSourceAndTarget(incrementalBackupCommandTextBox.Text);
            }
            if (e.Cancel)
            {
                incrementalBackupCommandTextBox.Focus();
                incrementalBackupGroupBox.ForeColor = Color.Red;
                MessageBox.Show("Az inkrementális mentés parancs ha nem üres, tartalmaznia kell a forrás és cél referenciákat.");
            }
            else
            {
                incrementalBackupGroupBox.ForeColor = Color.Black;
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
