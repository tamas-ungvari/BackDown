using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BackDown
{
    [DataContract]
    public class BackupSettings
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Source { get; set; }

        [DataMember]
        public string Target { get; set; }

        [DataMember]
        public bool Incremental { get; set; }

        public CliTool CliTool { get; set; }

        public List<Journal> Journals { get; set; } 
    }
}
