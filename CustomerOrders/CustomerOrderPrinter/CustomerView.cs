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
                Console.WriteLine();
            }
        }

        public void PrintCustomerDetails(Customer customer)
        {
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.DateOfBirth.ToString(CultureInfo.CurrentCulture));
            Console.WriteLine("This customer's orders are:");
            PrintCustomerOrders(customer);
            
        }

        public void PrintCustomerOrders(Customer customer)
        {
            foreach (Order order in customer.Orders)
            {
                Console.WriteLine(order.Item);
                Console.WriteLine(order.OrderId);
                Console.WriteLine(order.Quantity);
                Console.WriteLine();
            }
        }


    }
}
