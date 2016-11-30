using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace AlbumWebApplication.Domain
{
    public class ImageRepository : IRepository
    {
        private CloudStorageAccount _storageAccount;
        private CloudBlobClient _blobClient;
        private CloudBlobContainer _container;

        public ImageRepository()
        {
            _storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("storageConnectionString"));
            _blobClient = _storageAccount.CreateCloudBlobClient();
            _container = _blobClient.GetContainerReference("cover-photo-container");
            _container.CreateIfNotExists();
        }

        public string DownloadRequestedImage(string name)
        {
            var blockBlob = _container.GetBlockBlobReference($"{name}.png");
            var fileToWriteTo = $@"C:\dl-album-images\{name}.png";
            try
            {
                using (var fileStream = File.OpenWrite(fileToWriteTo))
                {
                    blockBlob.DownloadToStream(fileStream);
                }
            }
            catch (StorageException e)
            {
                return e.Message;
            }
            return fileToWriteTo;
        }
        public IEnumerable GetAlbumData(string name)
        {
            return DownloadRequestedImage(name);
        }
    }

}
