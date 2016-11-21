using AlbumWebApplication.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
        public IHttpActionResult Get(string image)
        {
            _resolver.Register<IRepository, ImageRepository>();
            _repository = _resolver.ResolveRepository<IRepository>();
            IEnumerable result = _repository.GetAlbumData(image);
            return Ok(result);
        }

    }
}