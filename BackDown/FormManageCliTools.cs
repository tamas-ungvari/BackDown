using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackDown.Properties;

namespace BackDown
{
    public partial class FormManageCliTools : Form
    {

        private DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<CliTool>));

        public FormManageCliTools()
        {
            InitializeComponent();
            List<CliTool> cliTools = new List<CliTool>();
            bindingSourceCliTools.DataSource = cliTools;
            LoadCliToolsFromFile();
        }

        private void LoadCliToolsFromFile()
        {
            string fileName = Settings.Default.CLI_TOOLS_FILE;
            if (!File.Exists(fileName))
            {
                return;
            }
            using (Stream stream = new FileStream(fileName, FileMode.Open))
            {
                List<CliTool> cliTools = serializer.ReadObject(stream) as List<CliTool>;
                bindingSourceCliTools.DataSource = cliTools;
                dataGridViewCliTools.Refresh();
            }
        }

        private void SaveCliToolsToFile()
        {
            string fileName = Settings.Default.CLI_TOOLS_FILE;
            using (Stream stream = new FileStream(fileName, FileMode.Create))
            {
                serializer.WriteObject(stream, bindingSourceCliTools.DataSource as List<CliTool>);
            }

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
                SaveCliToolsToFile();
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
                SaveCliToolsToFile();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bindingSourceCliTools.RemoveCurrent();
            SaveCliToolsToFile();
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
