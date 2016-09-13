using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendModel
{
    public class Order
    {
        private int orderId;
        private string item;
        private int quantity;

        public Order(int orderId, string item, int quantity)
        {
            this.orderId = orderId;
            this.item = item;
            this.quantity = quantity;
            
        }

        public object getInstance()
        {
            return this;
        }

        public int getId()
        {
            return this.orderId;
        }
    }
}
