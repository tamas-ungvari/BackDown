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
            bool nameIsEmpty = string.IsNullOrEmpty(textBoxCliToolName.Text);
            bool backupCommandIsEmpty = string.IsNullOrEmpty(textBoxBackupCommand.Text);
            bool restoreCommandIsEmpty = string.IsNullOrEmpty(textBoxRestoreCommand.Text);
            bool incrementalBackupCommandEmpty = string.IsNullOrEmpty(textBoxIncrementalBackupCommand.Text);
            if (nameIsEmpty || backupCommandIsEmpty || restoreCommandIsEmpty)
            {
                MessageBox.Show("Hiányzó név, mentés vagy helyreállítás parancs", 
                    "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
            else
            {
                (bindingSource.Current as CliTool).IncrementalBackupEnabled = !incrementalBackupCommandEmpty;
            }
        }
    }
}
