using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendModel
{
    public class CustomerOperations
    {
        public virtual Customer CustomerObject { get; set; }

        public int GetNumberOfOrders()
        {
            return CustomerObject.Orders.Count;
        }

        public int GetCustomerAge()
        {
            return DateTime.Today.Year - CustomerObject.DateOfBirth.Year;
        }

        public void AddOrder(Order newOrder)
        {
            CustomerObject.Orders.Add(newOrder);
        }

        public Order GetOrder(int index)
        {
            return (Order)CustomerObject.Orders[index];
        }
    }
}
