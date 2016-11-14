using System.Web.Http;
using CoffeeManager.Domain;

namespace CoffeeManager.Api.Controllers
{
    public class HomeController : ApiController
    {
        private readonly CoffeeRepository _coffeeRepository = new CoffeeRepository();

        
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_coffeeRepository.GetCoffeeList());
            }
            catch
            {
                return NotFound();
            }
        }
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(_coffeeRepository.GetCoffeeList(id));
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
