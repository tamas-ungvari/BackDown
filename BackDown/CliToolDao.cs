using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using BackDown.Properties;

namespace BackDown
{
    public class CliToolDao
    {
        private static CliToolDao _instance;
        
        public static CliToolDao Instance {
            get
            {
                if (_instance == null)
                {
                    _instance = new CliToolDao();
                }
                return _instance;
            }
        }

        private DataContractJsonSerializer listSerializer = new DataContractJsonSerializer(typeof(List<CliTool>));
        private DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(CliTool));

        private CliToolDao() {}

        public List<CliTool> LoadListFromFile()
        {
            string fileName = Settings.Default.CLI_TOOLS_FILE;
            if (!File.Exists(fileName))
            {
                return null;
            }
            using (Stream stream = new FileStream(fileName, FileMode.Open))
            {
                List<CliTool> list = listSerializer.ReadObject(stream) as List<CliTool>;
                return list ?? new List<CliTool>();
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
