using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace Domain
{
    public class AzureStorageTableHelper
    {
        private CloudStorageAccount _storageAccount;
        private CloudTableClient _tableClient;
        private CloudTable _table;

        public AzureStorageTableHelper()
        {
            _storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            _tableClient = _storageAccount.CreateCloudTableClient();
            _table = _tableClient.GetTableReference("simpsons");

            _table.CreateIfNotExists();
        }

        public List<Character> GetAllCharacters()
        {
            return _table.ExecuteQuery(new TableQuery<Character>()).ToList();
        }

        public List<Character> GetCharacterWithFirstName(string partitionKey)
        {
            var queryToExecute =
                new TableQuery<Character>().Where(TableQuery.GenerateFilterCondition("PartitionKey",
                    QueryComparisons.Equal, partitionKey));
            return queryToExecute.ToList();
        }
    }
}
