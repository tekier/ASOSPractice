using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.Contracts
{
    public class Coffee
    {
        public int id { get; set; }
        public int strength { get; set; }
        public string country { get; set; }
        public bool decaf { get; set; }
    }
}
