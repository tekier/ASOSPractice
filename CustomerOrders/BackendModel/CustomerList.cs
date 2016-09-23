using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace BackendModel
{
    public class CustomerList
    {
        public virtual List<CustomerDetails> ListOfCustomers { get; set; }
        public string PathName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..","..", "ApplicationData.json");
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

        public void ConvertToJson(List<CustomerDetails> inputObj, string path)
        {
            string json = JsonConvert.SerializeObject(inputObj, Formatting.Indented);
            File.WriteAllText(PathName, json);
        }

        public void ConvertToJson(List<CustomerDetails> inputObj)
        {
            Console.WriteLine(PathName);
            string json = JsonConvert.SerializeObject(inputObj, Formatting.Indented);
            File.WriteAllText(PathName, json);

        }
        


        //Mainly for testing
        public void LoadJson(string path)
        {
            string json = System.IO.File.ReadAllText(path);
            this.ListOfCustomers = JsonConvert.DeserializeObject<List<CustomerDetails>>(json);
        }

        public void LoadJson()
        {
            string json = System.IO.File.ReadAllText(PathName);
            this.ListOfCustomers = JsonConvert.DeserializeObject<List<CustomerDetails>>(json);
        }
    }
}
