using System.Collections;
using System.Collections.Generic;

namespace AlbumWebApplication.Domain
{
    public interface IRepository
    {
        IEnumerable GetAlbumData(int id);
    }
}