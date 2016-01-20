using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BackDown
{
    [DataContract]
    public class CliTool
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string BackupCommand { get; set; }

        [DataMember]
        public string RestoreCommand { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
