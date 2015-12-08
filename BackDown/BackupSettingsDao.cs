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

        private readonly DataContractJsonSerializer listSerializer = new DataContractJsonSerializer(typeof(List<BackupSettings>));
        private readonly DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(BackupSettings));

        private BackupSettingsDao()
        {
        }

        public List<BackupSettings> LoadBackupSettingsList()
        {
            string backupSettingsFile = Settings.Default.BACKUP_SETTINGS_LIST_FILE;
            try
            {
                using (Stream stream = File.OpenRead(backupSettingsFile))
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
            string backupSettingsFile = Settings.Default.BACKUP_SETTINGS_LIST_FILE;
            using (Stream stream = File.Create(backupSettingsFile))
            {
                listSerializer.WriteObject(stream, list);
            }
        }

        public void SaveBackupSettings(string targetFolder, BackupSettings backupSettings)
        {
            string path = string.Format("{0}\\{1}", targetFolder, Settings.Default.BACKUP_SETTINGS_FILE);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (Stream stream = File.Create(path))
            {
                serializer.WriteObject(stream, backupSettings);
            }
        }

        public BackupSettings LoadBackupSettings(string targetFolder)
        {
            string path = string.Format("{0}\\{1}", targetFolder, Settings.Default.BACKUP_SETTINGS_FILE);
            try
            {
                using (Stream stream = File.OpenRead(path))
                {
                    return serializer.ReadObject(stream) as BackupSettings;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
