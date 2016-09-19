using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BackendModel;

namespace CustomersOrderDisplayWebsite.Models
{
    public class CustomerOrdersContext : DbContext
    {
        public DbSet<CustomerDetails> Customers { get; set; }
    }
}