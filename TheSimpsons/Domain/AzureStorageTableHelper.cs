using System.Collections.Generic;
using System.Linq;
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
            _storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=tekier;AccountKey=hxHcT89mFxOmO2XEYOsLYEhwm/gTQL8MbhiRnvKg8gIzY2bgVMCj3WvhtxWPj/uNWagoYVktG4lHWiW4Qs2EXg==");
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
                new TableQuery<Character>().Where(TableQuery.GenerateFilterCondition("RowKey",
                    QueryComparisons.Equal, partitionKey));
            return _table.ExecuteQuery(queryToExecute).ToList();
        }
    }
}
