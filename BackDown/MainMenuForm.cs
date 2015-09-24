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
            formManageCliTools.ShowDialog(this);
        }

        private void buttonManageBackups_Click(object sender, EventArgs e)
        {
            BackupManagerForm formManageBackups = new BackupManagerForm();
            formManageBackups.ShowDialog(this);
        }

        private void buttonRecover_Click(object sender, EventArgs e)
        {
            JournalAndRecoverForm formRecover = new JournalAndRecoverForm();
            formRecover.ShowDialog(this);
        }

    }
}
