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
    public partial class FormManageCliTools : Form
    {
        public FormManageCliTools()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            CliToolForm cliToolForm = new CliToolForm();
            if (DialogResult.OK == cliToolForm.ShowDialog())
            {
                listBoxCliTools.Items.Add(cliToolForm.CliTool);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            CliTool selected = (CliTool)listBoxCliTools.SelectedItem;

            CliToolForm cliToolForm = new CliToolForm();
            cliToolForm.CliTool = selected;

            cliToolForm.Text = string.Format("{0} parancssori eszköz szerkesztése", selected.Name);
            if (DialogResult.OK == cliToolForm.ShowDialog())
            {
                listBoxCliTools.SelectedItem = cliToolForm.CliTool;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBoxCliTools.Items.RemoveAt(listBoxCliTools.SelectedIndex);
        }

        private void listBoxCliTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enabled = listBoxCliTools.SelectedItem != null;
            buttonEdit.Enabled = enabled;
            buttonDelete.Enabled = enabled;
        }
    }
}
