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
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            return Ok();
        }

    }
}