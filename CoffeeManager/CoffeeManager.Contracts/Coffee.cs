using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace CoffeeManager.Contracts
{
    public class Coffee
    {
        [KeyAttribute]
        public int ?Id { get; set; }
        public int Strength { get; set; }
        public string Country { get; set; }
        public bool IsDecaf { get; set; }
    }
}
