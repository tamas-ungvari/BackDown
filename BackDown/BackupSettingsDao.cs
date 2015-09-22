using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
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

        private DataContractJsonSerializer listSerializer = new DataContractJsonSerializer(typeof(List<BackupSettings>));

        private BackupSettingsDao()
        {
        }

        public List<BackupSettings> LoadBackupSettingsList()
        {
            string backupSettingsFile = Settings.Default.BACKUP_SETTINGS_FILE;
            try
            {
                using (Stream stream = new FileStream(backupSettingsFile, FileMode.Open))
                {
                    return listSerializer.ReadObject(stream) as List<BackupSettings> ?? new List<BackupSettings>();
                }
            }
            catch (Exception)
            {
                return new List<BackupSettings>();
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
