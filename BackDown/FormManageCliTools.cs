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
            cliToolForm.BindingSource = bindingSourceCliTools;
            bindingSourceCliTools.AddNew();
            if (DialogResult.OK != cliToolForm.ShowDialog())
            {
                bindingSourceCliTools.CancelEdit();
            }
            else
            {
                dataGridViewCliTools.Refresh();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            CliToolForm cliToolForm = new CliToolForm();
            cliToolForm.BindingSource = bindingSourceCliTools;

            CliTool selected = bindingSourceCliTools.Current as CliTool;
            cliToolForm.Text = string.Format("{0} parancssori eszköz szerkesztése", selected.Name);
            if (DialogResult.OK == cliToolForm.ShowDialog())
            {
                dataGridViewCliTools.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bindingSourceCliTools.RemoveCurrent();
        }

        private void dataGridViewCliTools_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void dataGridViewCliTools_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
        }

    }
}
