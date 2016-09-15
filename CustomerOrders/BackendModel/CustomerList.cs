using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendModel
{
    public class CustomerList
    {
        private List<CustomerOperations> _listOfCustomers = new List<CustomerOperations>();

        public void AddCustomer(CustomerOperations newCustomerOperations)
        {
            _listOfCustomers.Add(newCustomerOperations);
        }

        public CustomerOperations GetCustomer(int returnId)
        {
            return (CustomerOperations) _listOfCustomers[returnId];
        }

        public int NumberOfCustomers()
        {
            return _listOfCustomers.Count;
        }
        
    }
}
