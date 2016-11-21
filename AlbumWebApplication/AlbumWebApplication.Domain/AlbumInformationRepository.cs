using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumWebApplication.Contracts;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace AlbumWebApplication.Domain
{
    public class AlbumInformationRepository : IRepository
    {
        private static CloudStorageAccount _storageAccount;
        private static CloudTableClient _tableClient;
        private static CloudTable _table;

        public AlbumInformationRepository()
        {
            _storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            _tableClient = _storageAccount.CreateCloudTableClient();
            _table = _tableClient.GetTableReference("albums");
            _table.CreateIfNotExists();
        }

        public IEnumerable GetAlbumData(string id)
        {
            return _table.ExecuteQuery(new TableQuery<AlbumEntity>()).ToList();
        }
    }
}
