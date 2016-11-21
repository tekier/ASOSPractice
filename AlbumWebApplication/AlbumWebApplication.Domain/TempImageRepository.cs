using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumWebApplication.Contracts;

namespace AlbumWebApplication.Domain
{
    public class TempImageRepository : IRepository
    {
        private readonly List<ImageLocation> _imageLocations;
        private const string RootPath = @"C:/album_images/";
        public TempImageRepository()
        {
            _imageLocations = new List<ImageLocation>()
            {
                new ImageLocation("sd5",RootPath+"saladdays"),
                new ImageLocation("ec7", RootPath+"eternalchamp"),
                new ImageLocation("cb6", RootPath+"cherrybomb"),
                new ImageLocation("ls5", RootPath+"luckyshiner")
            };
        }
        public IEnumerable GetAlbumData(int id)
        {
            return _imageLocations;
        }
    }
}
