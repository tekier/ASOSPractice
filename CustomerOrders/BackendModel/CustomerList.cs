﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BackendModel
{
    public class CustomerList
    {
        public virtual List<CustomerOperations> ListOfCustomers { get; set; }

        public void AddCustomer(CustomerOperations newCustomerOperations)
        {
            ListOfCustomers.Add(newCustomerOperations);
        }

        public CustomerOperations GetCustomer(int returnId)
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

        public void toJSON(List<CustomerOperations> inputObj, string path)
        {
            string json = JsonConvert.SerializeObject(inputObj, Formatting.Indented);
            System.IO.File.WriteAllText(path + "ApplicationData.json", json);
            
        }
}
}
