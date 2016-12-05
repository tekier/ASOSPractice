using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace Contracts
{
    public sealed class Character : TableEntity
    {
        public Character(string  forename, string surname, int age, string specialItem)
        {
            PartitionKey = forename;
            RowKey = surname;
            Age = age;
            SpecialItem = specialItem;
        }

        public Character()
        {
            
        }

        public int Age { get; set; }
        public string SpecialItem { get; set; }
    }
}
