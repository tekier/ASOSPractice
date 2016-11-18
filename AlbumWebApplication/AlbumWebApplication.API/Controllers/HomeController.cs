using System.Web.Http;
using AlbumWebApplication.Domain;

namespace AlbumWebApplication.API.Controllers
{
    public class HomeController : ApiController
    {
        private readonly TempRepository _repository = new TempRepository();
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_repository.GetAlbumList());
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
