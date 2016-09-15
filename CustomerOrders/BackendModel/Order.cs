using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendModel
{
    public class Order
    {
        public virtual int OrderId { get; set; }
        public virtual string Item { get; set; }
        public virtual int Quantity { get; set; }

    }
}
