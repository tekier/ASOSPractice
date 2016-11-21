using System.Web.Http;
using AlbumWebApplication.Domain;
using Newtonsoft.Json.Serialization;

namespace AlbumWebApplication.API.Controllers
{
    public class HomeController : ApiController
    {
        private readonly Resolver _resolver = new Resolver();
        private IRepository _repository;

        public IHttpActionResult Get()
        {
            _resolver.Register<IRepository, TempRepository>();
            _repository = _resolver.ResolveRepository<IRepository>();
            try
            {
                return Ok(_repository.GetAlbumData(""));
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
