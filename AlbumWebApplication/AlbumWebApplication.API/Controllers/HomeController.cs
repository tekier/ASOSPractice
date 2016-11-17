using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AlbumWebApplication.API.Controllers
{
    public class HomeController : ApiController
    {
        private TempRepository _repository = new TempRepository();
        public IHttpActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
