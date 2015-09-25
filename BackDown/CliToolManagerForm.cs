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
        private CliToolDao cliToolsDao = CliToolDao.Instance;

        public CliToolManagerForm()
        {
            InitializeComponent();
            bindingSourceCliTools.DataSource = cliToolsDao.LoadListFromFile();
            cliToolsDataGridView.Refresh();
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
                    cliToolsDataGridView.Refresh();
                    CheckNameUnique();
                    break;
                }
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            CliToolForm cliToolForm = new CliToolForm();
            cliToolForm.BindingSource = bindingSourceCliTools;
            bindingSourceCliTools.AddNew();
            if (DialogResult.OK != cliToolForm.ShowDialog())
            {
                bindingSourceCliTools.CancelEdit();
                bindingSourceCliTools.DataSource = cliToolsDao.LoadListFromFile();
                cliToolsDataGridView.Refresh();
            }
            else
            {
                CheckNameUnique();
                cliToolsDao.SaveListToFile(bindingSourceCliTools.DataSource as List<CliTool>);
                cliToolsDataGridView.Refresh();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CliToolForm cliToolForm = new CliToolForm();
            cliToolForm.BindingSource = bindingSourceCliTools;

            CliTool selected = bindingSourceCliTools.Current as CliTool;
            cliToolForm.Text = string.Format("{0} parancssori eszköz szerkesztése", selected.Name);
            if (DialogResult.OK == cliToolForm.ShowDialog())
            {
                CheckNameUnique();
                cliToolsDao.SaveListToFile(bindingSourceCliTools.DataSource as List<CliTool>);
                cliToolsDataGridView.Refresh();
            }
            else
            {
                bindingSourceCliTools.DataSource = cliToolsDao.LoadListFromFile();
                cliToolsDataGridView.Refresh();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bindingSourceCliTools.RemoveCurrent();
            cliToolsDataGridView.Refresh();
            cliToolsDao.SaveListToFile(bindingSourceCliTools.DataSource as List<CliTool>);
        }

        private void cliToolsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void cliToolsDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            editButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void importButton_Click(object sender, EventArgs e)
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
                        cliToolsDataGridView.Refresh();
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
