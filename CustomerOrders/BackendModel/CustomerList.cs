using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BackendModel
{
    public class CustomerList
    {
        public virtual List<CustomerDetails> ListOfCustomers { get; set; }
        public string PathName = Path.Combine(Directory.GetCurrentDirectory(), "ApplicationData.json");

        public void AddCustomer(CustomerDetails newCustomerDetails)
        {
            ListOfCustomers.Add(newCustomerDetails);
        }

        public CustomerDetails GetCustomer(int returnId)
        {
            return ListOfCustomers.Find(customer => customer.GetCustomerId() == returnId);
        }

        public int NumberOfCustomers()
        {
            return ListOfCustomers.Count;
        }

        public void AddNewOrder(Order order, int custId)
        {
            ListOfCustomers.Find(customer => customer.GetCustomerId() == custId).AddOrder(order);
        }

        public object GetOrder(int custId, int orderId)
        {
            return ListOfCustomers.Find(customer => customer.GetCustomerId() == custId).GetOrder(orderId);
        }

        public void ToJSON(List<CustomerDetails> inputObj)
        {
            string json = JsonConvert.SerializeObject(inputObj, Formatting.Indented);
            System.IO.File.WriteAllText(PathName, json);
            
        }

        public void LoadJson()
        {
            string json = System.IO.File.ReadAllText(PathName);
            this.ListOfCustomers = JsonConvert.DeserializeObject<List<CustomerDetails>>(json);
        }
    }
}
