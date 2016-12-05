using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Contracts;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace InitializeToAzureTable
{
    public class TableInitializer
    {
        private readonly CloudTable _table;

        public TableInitializer()
        {
            var cloudAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            var cloudTableClient = cloudAccount.CreateCloudTableClient();
            _table = cloudTableClient.GetTableReference("simpsons");
            _table.CreateIfNotExists();
        }

        public void PopulateTable()
        {
            List<Character> listOfCharacters = new List<Character>
            {
                new Character("Bart", "Simpson", 10, "skateboard"),
                new Character("Marge", "Bouvier", 36, "spatula"),
                new Character("Ralph", "Wiggum", 11, "hair"),
                new Character("Hans", "Moleman", 50, "cane"),
                new Character("Maggie", "Simpson", 1, "pacifier"),
                new Character("Moe", "Szyslak", 46, "shotgun")
            };

            foreach (var character in listOfCharacters)
            {
                var insertionOperation = TableOperation.InsertOrMerge(character);
                _table.Execute(insertionOperation);
            }
        }

        public void ClearTable()
        {
            _table.Delete();
        }
    }
}
