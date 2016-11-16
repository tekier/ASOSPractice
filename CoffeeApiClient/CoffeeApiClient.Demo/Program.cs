using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoffeeApiClient.ClientApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CoffeeApiClient.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeClient client = new CoffeeClient();
            GetCoffeesById(client);
            GetAllCoffees(client);
            Console.Read();
        }

        private static void GetAllCoffees(CoffeeClient client)
        {
            Console.WriteLine("\n******** Getting full list of Coffees ********\n");
            PrintCoffeeListToConsole(client.GetAllCoffees().Result);
        }

        private static void GetCoffeesById(CoffeeClient client)
        {
            int i = 1;
            Console.WriteLine("******** Getting coffees individually by id ********\n");
            string result = client.GetCoffeeById(i).Result;
            do
            {
                PrintSingleCoffeeJsonToConsole(result);
                i++;
                result = client.GetCoffeeById(i).Result;
            } while (!result.Equals("[]"));
        }

        private static void PrintCoffeeListToConsole(string result)
        {
            dynamic resultAsJson = JsonConvert.DeserializeObject(result);
            foreach (var json in resultAsJson)
            {
                AsString(json);
            } 
        }

        private static void PrintSingleCoffeeJsonToConsole(string result)
        {
            result = result.Substring(1, result.Length - 2);
            dynamic resultAsJson = JsonConvert.DeserializeObject(result);
            AsString(resultAsJson);
        }

        private static void AsString(dynamic resultAsJson)
        {
            try
            {
                Console.WriteLine("\nCountry of origin: {0}", resultAsJson["Country"]);
                Console.WriteLine("Strength of {0}/5", resultAsJson["Strength"]);
                Console.WriteLine("This coffee is{0}decaf.\n", bool.Parse(resultAsJson["IsDecaf"].ToString()) ? " " : " not ");
                Console.WriteLine("------------------------------");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to parse JSON");
                Console.WriteLine("------------------------------");
            }
        }
    }
}
