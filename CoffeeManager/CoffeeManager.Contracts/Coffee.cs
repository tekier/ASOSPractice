using System.ComponentModel.DataAnnotations;

namespace CoffeeManager.Contracts
{
    public class Coffee
    {
        public int ?Id { get; set; }
        public int Strength { get; set; }
        public string Country { get; set; }
        public bool IsDecaf { get; set; }
    }
}
