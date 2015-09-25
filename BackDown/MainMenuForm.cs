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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void manageCliToolsButton_Click(object sender, EventArgs e)
        {
            CliToolManagerForm cliToolManagerForm = new CliToolManagerForm();
            cliToolManagerForm.ShowDialog(this);
        }

        private void manageBackupsButton_Click(object sender, EventArgs e)
        {
            BackupManagerForm backupManagerForm = new BackupManagerForm();
            backupManagerForm.ShowDialog(this);
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            JournalAndRecoverForm journalAndRecoverForm = new JournalAndRecoverForm();
            journalAndRecoverForm.ShowDialog(this);
        }

    }
}
