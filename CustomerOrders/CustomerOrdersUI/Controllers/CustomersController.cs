using System;
using System.IO;
using System.Reflection;
using System.Web.Mvc;
using BackendModel;

namespace CustomerOrdersUI.Controllers
{
    public class CustomersController : Controller {
    
        private CustomerList _list = new CustomerList();
        
        // GET: Customers
        public ActionResult Index()
        {
            _list.LoadJson(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "ApplicationData.json"));
            ViewBag.Customers = _list.ListOfCustomers;
            return View();
        }

    }
}