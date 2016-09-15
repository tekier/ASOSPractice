using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendModel
{
    public class Order
    {
        public virtual int _orderId { get; set; }
        public virtual string _item { get; set; }
        public virtual int _quantity { get; set; }

    }
}
