using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using BackDown.Properties;

namespace BackDown
{
    public class BackupSettingsDao
    {
        private static BackupSettingsDao _instance;

        public static BackupSettingsDao Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BackupSettingsDao();
                }
                return _instance;
            }
        }

        private DataContractSerializer listSerializer = new DataContractSerializer(typeof(List<BackupSettings>));

        private BackupSettingsDao()
        {
        }

        public List<BackupSettings> LoadBackupSettingsList()
        {
            string backupSettingsFile = Settings.Default.BACKUP_SETTINGS_FILE;
            using (Stream stream = new FileStream(backupSettingsFile, FileMode.Open))
            {
                return listSerializer.ReadObject(stream) as List<BackupSettings> ?? new List<BackupSettings>();
            }
        }

        public void SaveBackupSettingsList(List<BackupSettings> list)
        {
            string backupSettingsFile = Settings.Default.BACKUP_SETTINGS_FILE;
            using (Stream stream = new FileStream(backupSettingsFile, FileMode.Create))
            {
                listSerializer.WriteObject(stream, list);
            }
        }
    }
}
