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

        private DataContractJsonSerializer listSerializer = new DataContractJsonSerializer(typeof(List<CliTool>));
        private DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(CliTool));

        public FormManageCliTools()
        {
            InitializeComponent();
            List<CliTool> cliTools = new List<CliTool>();
            bindingSourceCliTools.DataSource = cliTools;
            LoadCliToolsFromFile();
            string fileFilterText = "JSON files (.json)|*.json";
            openFileDialog.Filter = fileFilterText;
            openFileDialog.RestoreDirectory = true;
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
                List<CliTool> cliTools = listSerializer.ReadObject(stream) as List<CliTool>;
                bindingSourceCliTools.DataSource = cliTools;
                dataGridViewCliTools.Refresh();
            }
        }

        private void SaveCliToolsToFile()
        {
            CheckNameUnique();

            string fileName = Settings.Default.CLI_TOOLS_FILE;
            using (Stream stream = new FileStream(fileName, FileMode.Create))
            {
                listSerializer.WriteObject(stream, bindingSourceCliTools.DataSource as List<CliTool>);
            }
        }

        private void CheckNameUnique()
        {
            CliTool current = bindingSourceCliTools.Current as CliTool;
            foreach (CliTool tool in bindingSourceCliTools.List)
            {
                if (tool != current && tool.Name.Equals(current.Name))
                {
                    FormNewName formNewName = new FormNewName();
                    formNewName.nameTextBox.Text = current.Name;
                    DialogResult dialogResult = DialogResult.Cancel;
                    while (tool.Name.Equals(current.Name))
                    {
                        MessageBox.Show("Már létezik a rendszerben eszköz a megadott névvel. Kérem adjon meg egy új nevet.");

                        dialogResult = formNewName.ShowDialog(this);
                        if (dialogResult == DialogResult.OK)
                        {
                            current.Name = formNewName.nameTextBox.Text;
                        }
                    }
                    dataGridViewCliTools.Refresh();
                    CheckNameUnique();
                    break;
                }
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

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream stream;
                    if ((stream = openFileDialog.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            bindingSourceCliTools.Add(serializer.ReadObject(stream));
                            bindingSourceCliTools.Position = bindingSourceCliTools.Count - 1;
                            SaveCliToolsToFile();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Az import fájl nem olvsható.");
                }
            }
        }

    }
}
