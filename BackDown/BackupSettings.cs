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

        [DataMember]
        public string CliToolName
        {
            get
            {
                return CliTool == null ? null : CliTool.Name; }
            set
            {
                List<CliTool> list = CliToolDao.Instance.LoadListFromFile();
                foreach (CliTool tool in list)
                {
                    if (tool.Name.Equals(value))
                    {
                        CliTool = tool;
                    }
                }
            }
        }

    }
}
