using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumWebApplication.Contracts;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace InitializationToAzure
{
    public class InitialiseTable
    {
        private static CloudStorageAccount _storageAccount;
        private static CloudTableClient _tableClient;
        private static CloudTable _table;

        public InitialiseTable()
        {
            _storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            _tableClient = _storageAccount.CreateCloudTableClient();
            _table = _tableClient.GetTableReference("albums");

            _table.CreateIfNotExists();
        }
        public void InsertIntoTable()
        {
            List<AlbumEntity> albumEntitiesAsRepository = new List<AlbumEntity>
            {
                new AlbumEntity("Salad Days", "Mac DeMarco") 
                {
                    Id = "saladdays",
                    Year = new DateTime(2013, 1, 1)
                },
                new AlbumEntity("Eternal Champ", "Sweet Valley")
                {
                    Id = "eternalchamp",
                    Year = new DateTime(2011, 1, 1)
                },
                new AlbumEntity("Cherry Bomb", "Tyler, The Creator")
                {
                    Id = "cherrybomb",
                    Year = new DateTime(2011, 1, 1)
                },
                new AlbumEntity("Lucky Shiner", "Gold Panda")
                {
                    Id = "luckyshiner",
                    Year = new DateTime(2010, 1, 1)
                }
            };

            foreach (var album in albumEntitiesAsRepository)
            {
                var insertOp = TableOperation.Insert(album);
                _table.Execute(insertOp);
            }
            Console.WriteLine("all insertions completed.");
        }
    }
}
