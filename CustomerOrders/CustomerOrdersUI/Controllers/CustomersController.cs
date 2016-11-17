using System;
using System.IO;
using System.Web.Mvc;
using BackendModel;
using Microsoft.Ajax.Utilities;

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

        public ActionResult GetCustomerDetails(int custId = 7)
        {
            _list.LoadJson(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "ApplicationData.json"));
            ViewBag.Customer = _list.GetCustomer(custId);
            return View();
        }

        public ActionResult

    }
}