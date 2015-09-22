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
    public partial class CliToolManagerForm : Form
    {
        private CliToolsDao cliToolsDao = CliToolsDao.Instance;

        public CliToolManagerForm()
        {
            InitializeComponent();
            bindingSourceCliTools.DataSource = cliToolsDao.LoadListFromFile();
            dataGridViewCliTools.Refresh();
            string fileFilterText = "JSON files (.json)|*.json";
            openFileDialog.Filter = fileFilterText;
            openFileDialog.RestoreDirectory = true;
        }

        private void CheckNameUnique()
        {
            CliTool current = bindingSourceCliTools.Current as CliTool;
            foreach (CliTool tool in bindingSourceCliTools.List)
            {
                if (tool != current && tool.Name.Equals(current.Name))
                {
                    NewNameForm formNewName = new NewNameForm();
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
                CheckNameUnique();
                cliToolsDao.SaveListToFile(bindingSourceCliTools.DataSource as List<CliTool>);
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
                CheckNameUnique();
                cliToolsDao.SaveListToFile(bindingSourceCliTools.DataSource as List<CliTool>);
                dataGridViewCliTools.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bindingSourceCliTools.RemoveCurrent();
            dataGridViewCliTools.Refresh();
            cliToolsDao.SaveListToFile(bindingSourceCliTools.DataSource as List<CliTool>);
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
                       
                        bindingSourceCliTools.Add(cliToolsDao.LoadFromStream(stream));
                        bindingSourceCliTools.Position = bindingSourceCliTools.Count - 1;
                        dataGridViewCliTools.Refresh();
                        CheckNameUnique();
                        cliToolsDao.SaveListToFile(bindingSourceCliTools.DataSource as List<CliTool>);
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
