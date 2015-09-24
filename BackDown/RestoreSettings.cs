using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDown
{
    public class RestoreSettings
    {
        public CliTool CliTool { get; set; }
        public string BackupFolder { get; set; }
        public string RestoreFolder { get; set; }
        public string Name { get; set; }
    }
}
