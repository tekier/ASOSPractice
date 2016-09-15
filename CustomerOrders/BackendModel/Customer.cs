using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendModel
{
    public class Customer
    {
        public virtual string Name { get; set; }

        public virtual DateTime DateOfBirth { get; set; }

        public virtual List<Order> Orders { get; set; }

        public virtual CustomerAddress CustomerAddress { get; set; }
       
    }
}
