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
        private CliTool cliTool = new CliTool();

        public CliTool CliTool { 
            get { return cliTool; }
            set { cliTool = value; } 
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
                cliTool.Name = textBoxCliToolName.Text;
                cliTool.BackupCommand = textBoxBackupCommand.Text;
                cliTool.IncrementalBackupEnabled = !incrementalBackupCommandEmpty;
                cliTool.IncrementalBackupCommand = textBoxIncrementalBackupCommand.Text;
                cliTool.RestoreCommand = textBoxRestoreCommand.Text;
            } 
        }
    }
}
