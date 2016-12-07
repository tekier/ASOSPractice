using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain;

namespace API.Controllers
{
    public class ClearController : ApiController
    {
        private RedisCacheHelper _redis;

        public IHttpActionResult GetClear()
        {
            _redis = new RedisCacheHelper();
            _redis.ClearTheWholeThing();
            return Ok();
        }
    }
}
