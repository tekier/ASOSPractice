using System.Net;
using System.Net.Http;
using System.Web.Http;
using CoffeeManager.Domain;

namespace CoffeeManager.Api.Controllers
{
    public class HomeController : ApiController
    {
        private readonly CoffeeObjectMapper _mapper = new CoffeeObjectMapper();
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_mapper.GetCoffeeListFromDatabase());
            }
            catch
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
        }
    }
}
