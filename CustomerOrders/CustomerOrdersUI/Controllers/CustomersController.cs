using System.Web.Mvc;
using BackendModel;

namespace CustomerOrdersUI.Controllers
{
    public class CustomersController : Controller {
    
        private CustomerList list = new CustomerList();
        
        // GET: Customers
        public ActionResult Index()
        {
            list.LoadJson("C:\\Users\\ahmed.sohail\\Documents\\ApplicationData.json");
            ViewBag.Customers = list.ListOfCustomers;
            return View();
        }
    }
}