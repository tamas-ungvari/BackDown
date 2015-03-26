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
    public partial class FormBackDown : Form
    {
        public FormBackDown()
        {
            InitializeComponent();
        }

        private void buttonManageCliTools_Click(object sender, EventArgs e)
        {
            FormManageCliTools formManageCliTools = new FormManageCliTools();
            if (DialogResult.OK == formManageCliTools.ShowDialog())
            {

            }

        }

        private void buttonManageBackups_Click(object sender, EventArgs e)
        {
            FormManageBackups formManageBackups = new FormManageBackups();
            if (DialogResult.OK == formManageBackups.ShowDialog())
            {

            }
        }

        private void buttonRecover_Click(object sender, EventArgs e)
        {
            FormRecover formRecover = new FormRecover();
            if (DialogResult.OK == formRecover.ShowDialog())
            {

            }
        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            FormLogs formLogs = new FormLogs();
            if (DialogResult.OK == formLogs.ShowDialog())
            {

            }
        }
    }
}
