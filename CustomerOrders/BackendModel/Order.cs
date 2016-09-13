using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendModel
{
    public class Order
    {
        private readonly int _orderId;
        private readonly string _item;
        private readonly int _quantity;

        public Order(int orderId, string item, int quantity)
        {
            this._orderId = orderId;
            this._item = item;
            this._quantity = quantity;
            
        }

        public object GetInstance()
        {
            return this;
        }

        public int GetId()
        {
            return this._orderId;
        }

        public string GetItemName()
        {
            return this._item;
        }

        public int GetQuantity()
        {
            return this._quantity;
        }
    }
}
