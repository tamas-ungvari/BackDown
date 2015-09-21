using System;
using System.Runtime.Serialization;

namespace BackDown
{
    [DataContract]
    public class Journal
    {
        public string JournalFile { get; set; }

        public Backup Backup { get; set; }

        [DataMember]
        public DateTime BackupDateTime { get; set; }

        [DataMember]
        public string Note { get; set; }

        [DataMember]
        public string JournalText { get; set; }
    }
}