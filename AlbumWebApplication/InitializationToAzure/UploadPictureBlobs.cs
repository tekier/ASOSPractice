using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace InitializationToAzure
{
    public class UploadPictureBlobs
    {
        private CloudStorageAccount _storageAccount;
        private CloudBlobClient _blobClient;
        private CloudBlobContainer _container;

        //public UploadPictureBlobs()
        //{
        //    _storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("storageConnectionString"));
        //    _blobClient = _storageAccount.CreateCloudBlobClient();
        //    _container = _blobClient.GetContainerReference("cover-photo-container");
        //    _container.CreateIfNotExists();
        //}

        public void UploadBlobs()
        {
            string[] files = Directory.GetFiles("C:/album_images/");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
