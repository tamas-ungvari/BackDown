using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDown
{
    public class CliTool
    {

        string name;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        string backupCommand;

        public string BackupCommand
        {
            get { return backupCommand; }
            set { backupCommand = value; }
        }

        string restoreCommand;

        public string RestoreCommand
        {
            get { return restoreCommand; }
            set { restoreCommand = value; }
        }

        string incrementalBackupCommand;

        public string IncrementalBackupCommand
        {
            get { return incrementalBackupCommand; }
            set { incrementalBackupCommand = value; }
        }

        bool incrementalBackupEnabled;

        public bool IncrementalBackupEnabled
        {
            get { return incrementalBackupEnabled; }
            set { incrementalBackupEnabled = value; }
        }

        public override string ToString()
        {
            return String.Format("{0}, inkrementális: {1}", name, incrementalBackupEnabled ? "igen" : "nem");
        }

    }
}
