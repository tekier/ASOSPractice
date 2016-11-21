using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializationToAzure
{
    class Program
    {
        static void Main(string[] args)
        {
            UploadPictureBlobs i = new UploadPictureBlobs();
            i.UploadBlobs();
            Console.Read();
        }
    }
}
