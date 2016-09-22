using System;
using System.Collections.Generic;

namespace BackendModel
{
    public class Customer
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual DateTime DateOfBirth { get; set; }

        public virtual List<Order> Orders { get; set; }

        public virtual CustomerAddress CustomerAddress { get; set; }
       
    }
}
