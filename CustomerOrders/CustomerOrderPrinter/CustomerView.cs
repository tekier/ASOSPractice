using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BackendModel;

namespace CustomerOrderPrinter
{
    class CustomerView

    {
        public void PrintAll(CustomerList list)
        {
            foreach (CustomerDetails customer in list.ListOfCustomers)
            {
                PrintCustomerDetails(customer.CustomerObject);
                Console.WriteLine("Age: "+customer.GetCustomerAge());
                Console.WriteLine();
                Console.WriteLine("This customer's orders are:");
                Console.WriteLine();
                PrintCustomerOrders(customer.CustomerObject);
                Console.WriteLine("_______________________________________________");
            }
        }

        public void PrintCustomerDetails(Customer customer)
        {
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("ID: "+ customer.Id);
            
        }

        public void PrintCustomerOrders(Customer customer)
        {
            foreach (Order order in customer.Orders)
            {
                Console.WriteLine("Item: " + order.Item);
                Console.WriteLine("Order ID: " + order.OrderId);
                Console.WriteLine("Number Of Units: " + order.Quantity);
                Console.WriteLine();
            }
        }


    }
}
