using AlbumWebApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AlbumWebApplication.API.Controllers
{
    
    public class ImageController : ApiController
    {
        private readonly Resolver _resolver = new Resolver();
        private IRepository _repository;
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            _resolver.Register<IRepository, TempImageRepository>();
            _repository = _resolver.ResolveRepository<IRepository>();
            return Ok(_repository.GetAlbumData(1));
        }

    }
}