using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApiClient.ClientApi
{
    class CallCoffeeClient
    {
        private readonly CoffeeClient _client = new CoffeeClient();
        public string GetCoffeeById(int id)
        {
            return _client.GetCoffeeFromApiById(id).Result;
        }
    }
}
