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

        private void buttonManageCliTools_Click(object sender, EventArgs e)
        {
            CliToolManagerForm formManageCliTools = new CliToolManagerForm();
            if (DialogResult.OK == formManageCliTools.ShowDialog())
            {

            }

        }

        private void buttonManageBackups_Click(object sender, EventArgs e)
        {
            BackupManagerForm formManageBackups = new BackupManagerForm();
            if (DialogResult.OK == formManageBackups.ShowDialog())
            {

            }
        }

        private void buttonRecover_Click(object sender, EventArgs e)
        {
            JournalAndRecoverForm formRecover = new JournalAndRecoverForm();
            if (DialogResult.OK == formRecover.ShowDialog())
            {

            }
        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            JournalViewerForm formLogs = new JournalViewerForm();
            if (DialogResult.OK == formLogs.ShowDialog())
            {

            }
        }
    }
}
