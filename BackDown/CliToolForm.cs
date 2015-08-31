using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                textBoxCliToolName.DataBindings.Add("Text", bindingSource, "name");
                textBoxBackupCommand.DataBindings.Add("Text", bindingSource, "backupCommand");
                textBoxIncrementalBackupCommand.DataBindings.Add("Text", bindingSource, "incrementalBackupCommand");
                textBoxRestoreCommand.DataBindings.Add("Text", bindingSource, "restoreCommand");
            }
        }

        public CliToolForm()
        {
            InitializeComponent();
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
            e.Cancel = string.IsNullOrEmpty(textBoxBackupCommand.Text);
            if (e.Cancel)
            {
                textBoxBackupCommand.Focus();
                groupBoxBackup.ForeColor = Color.Red;
            }
            else
            {
                groupBoxBackup.ForeColor = Color.Black;
            }
        }

        private void textBoxCliToolName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(textBoxCliToolName.Text);
            if (e.Cancel)
            {
                textBoxCliToolName.Focus();
                labelCliToolName.ForeColor = Color.Red;
            }
            else 
            {
                labelCliToolName.ForeColor = Color.Black;
            }
        }

        private void textBoxRestoreCommand_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(textBoxRestoreCommand.Text);
            if (e.Cancel)
            {
                textBoxRestoreCommand.Focus();
                groupBoxRestore.ForeColor = Color.Red;
            }
            else
            {
                groupBoxRestore.ForeColor = Color.Black;
            }
        }
    }
}
