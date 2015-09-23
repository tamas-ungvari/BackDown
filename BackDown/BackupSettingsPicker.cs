using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackDown
{
    public partial class BackupSettingsPicker : UserControl
    {
        readonly BackupSettingsDao backupSettingsDao = BackupSettingsDao.Instance;

        public BindingSource BindingSource
        {
            get { return backupSettingsBindingSource; }
        }

        public BackupSettingsPicker()
        {
            InitializeComponent();
        }

        public void RefreshView()
        {
            backupSettingsDataGridView.Refresh();
        }

        private void BackupSettingsPicker_Load(object sender, EventArgs e)
        {
            backupSettingsBindingSource.DataSource = backupSettingsDao.LoadBackupSettingsList();
            backupSettingsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            backupSettingsDataGridView.AutoResizeColumns();
        }

        private void backupSettingsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void backupSettingsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshView();
        }

    }
}
