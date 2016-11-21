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

        public UploadPictureBlobs()
        {
            _storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("storageConnectionString"));
            _blobClient = _storageAccount.CreateCloudBlobClient();
            _container = _blobClient.GetContainerReference("cover-photo-container");
            _container.CreateIfNotExists();
        }

        public void UploadBlobs()
        {
            string[] files = Directory.GetFiles(@"C:\album_images\");

            foreach (var file in files)
            {
                using (var fileStream = File.OpenRead(file))
                {
                    string[] directories = file.Split(Path.DirectorySeparatorChar);
                    string filename = directories[directories.Length-1];
                    var blockBlob = _container.GetBlockBlobReference(filename);
                    blockBlob.UploadFromStream(fileStream);
                }
                Console.WriteLine($"Uploaded {file}");
            }
        }

        public void ListBlobs()
        {
            foreach (var image in _container.ListBlobs(null, true))
            {
                var blob = (CloudBlockBlob) image;
                Console.WriteLine($"Retrieved image {blob.Uri}");
            }
        }

        public void DownloadBlobs()
        {
            var blockBlob = _container.GetBlockBlobReference("cherrybomb.png");
            using (var fileStream = File.OpenWrite(@"C:\dl-album-images\download.png"))
            {
                blockBlob.DownloadToStream(fileStream);
            }

            Console.WriteLine("Blob downloaded");
        }
    }
}
