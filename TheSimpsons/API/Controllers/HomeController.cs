using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain;

namespace API.Controllers
{
    public class HomeController : ApiController
    {
        private RedisCacheHelper _redis;
        private AzureStorageTableHelper _azure;

        public IHttpActionResult Clear()
        {
            _redis = new RedisCacheHelper();
            _redis.ClearTheWholeThing();
            return Ok();
        }
        public IHttpActionResult Get()
        {
          _redis = new RedisCacheHelper();
            try
            {
                if (_redis.CheckIfInCache("full list"))
                {
                    return Ok(_redis.RetrieveFromCache("full list"));
                }
                _azure = new AzureStorageTableHelper();
                var valueToReturn = _azure.GetAllCharacters();
                _redis.AddToCache(valueToReturn);
                return Ok(valueToReturn);
            }
            catch
            {
                
                return NotFound();
            }
        }

        public IHttpActionResult Get(string name)
        {
            _redis = new RedisCacheHelper();
            try
            {
                if (_redis.CheckIfInCache(name))
                {
                    return Ok(_redis.RetrieveFromCache(name));
                }
                _azure = new AzureStorageTableHelper();
                var valueToReturn = _azure.GetCharacterWithFirstName(name);
                _redis.AddToCache(valueToReturn);
                return Ok(valueToReturn);
            }
            catch
            {

                return NotFound();
            }
        }
    }
}
