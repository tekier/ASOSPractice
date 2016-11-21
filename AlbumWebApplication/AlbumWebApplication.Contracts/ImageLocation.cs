using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumWebApplication.Contracts
{
    public class ImageLocation
    {
        public virtual string ImageId { get; set; }
        public virtual string PathToImage { get; set; }

        public ImageLocation(string id, string path)
        {
            ImageId = id;
            PathToImage = path;
        }
    }
}
