using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace Contracts
{
    public class Characters : TableEntity
    {
        public Characters(string name, string gender)
        {
            PartitionKey = name;
            RowKey = gender;
        }

        public virtual int Age { get; set; }
        public virtual string VoiceActor { get; set; }
    }
}
