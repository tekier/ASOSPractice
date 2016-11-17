using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumWebApplication.Contracts;

namespace AlbumWebApplication.Domain
{
    public class TempRepository
    {
        private List<AlbumEntity> _albumEntitiesAsRepository;

        public TempRepository()
        {
            _albumEntitiesAsRepository = new List<AlbumEntity>();
            _albumEntitiesAsRepository.Add(new AlbumEntity("Salad Days", "Mac DeMarco")
            {
                Id = "sd5",
                Year = new DateTime(2013,1,1)

            });
            _albumEntitiesAsRepository.Add(new AlbumEntity("Eternal Champ", "Sweet Valley")
            {
                Id = "ec7",
                Year = new DateTime(2011,1,1)

            });
            _albumEntitiesAsRepository.Add(new AlbumEntity("Cherry Bomb", "Tyler, The Creator")
            {
                Id = "cb6",
                Year = new DateTime(2011,1,1)

            });
            _albumEntitiesAsRepository.Add(new AlbumEntity("Lucky Shiner", "Gold Panda")
            {
                Id = "ls5",
                Year = new DateTime(2010,1,1)

            });

        }

        public List<AlbumEntity> GetAlbumList()
        {
            return _albumEntitiesAsRepository;
        }


    }
}
