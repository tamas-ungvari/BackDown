using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackDown
{
    public partial class FormManageBackups : Form
    {
        CliToolsDao cliToolsDao = CliToolsDao.Instance;

        public FormManageBackups()
        {
            InitializeComponent();
            cliToolComboBox.DataSource = cliToolsDao.LoadListFromFile();
            cliToolComboBox.DisplayMember = "Name";
        }

        private void cliToolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CliTool cliTool = cliToolComboBox.SelectedItem as CliTool;
            incrementalCheckBox.Enabled = cliTool.IncrementalBackupEnabled;
            incrementalCheckBox.Checked &= cliTool.IncrementalBackupEnabled;
        }

        private void browseSourceButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == sourceFolderBrowserDialog.ShowDialog(this))
            {
                sourceTextBox.Text = sourceFolderBrowserDialog.SelectedPath;
            }
        }

        private void browseTargetButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == targetFolderBrowserDialog.ShowDialog(this))
            {
                targetTextBox.Text = targetFolderBrowserDialog.SelectedPath;
            }
        }

        private void startQuickBackupButton_Click(object sender, EventArgs e)
        {

        }
    }
}
