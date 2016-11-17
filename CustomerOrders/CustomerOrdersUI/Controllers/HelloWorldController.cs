using System.Web.Mvc;

namespace CustomerOrdersUI.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            //return "<h1>This is being returned from the index method.</b>";
            return View();
        }

        public ActionResult Welcome(string name = "tawqir", int age = 21)
        {

            ViewBag.Message = "Hello to -> " + name;
            ViewBag.NumTimes = age;

            return View();
        }
    }
}