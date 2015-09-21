using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using BackDown.Properties;

namespace BackDown
{
    public class CliToolsDao
    {
        private static CliToolsDao _instance;
        
        public static CliToolsDao Instance {
            get
            {
                if (_instance == null)
                {
                    _instance = new CliToolsDao();
                }
                return _instance;
            }
        }

        private DataContractJsonSerializer listSerializer = new DataContractJsonSerializer(typeof(List<CliTool>));
        private DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(CliTool));

        private CliToolsDao() {}

        public List<CliTool> LoadListFromFile()
        {
            string fileName = Settings.Default.CLI_TOOLS_FILE;
            if (!File.Exists(fileName))
            {
                return null;
            }
            using (Stream stream = new FileStream(fileName, FileMode.Open))
            {
                return listSerializer.ReadObject(stream) as List<CliTool>;
            }
        }

        public void SaveListToFile(List<CliTool> cliTools)
        {
            string fileName = Settings.Default.CLI_TOOLS_FILE;
            using (Stream stream = new FileStream(fileName, FileMode.Create))
            {
                listSerializer.WriteObject(stream, cliTools);
            }
        }

        public CliTool LoadFromStream(Stream stream)
        {
            using (stream)
            {
                return serializer.ReadObject(stream) as CliTool;
            }
        }

        public void WriteToStream(Stream stream, CliTool cliTool)
        {
            using (stream)
            {
                serializer.WriteObject(stream, cliTool);
            }
        }
    }
}
