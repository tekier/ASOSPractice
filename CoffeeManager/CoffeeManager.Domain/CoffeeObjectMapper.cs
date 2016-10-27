using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeManager.Contracts;
using Dapper;

namespace CoffeeManager.Domain
{
    public class CoffeeObjectMapper
    {
        private const string _databaseConnectionString =
            "Data Source=ASGLH-WL-11919;Initial Catalog=CoffeeDatabase;Integrated Security=True";

        private IEnumerable<Coffee> _coffeeList;
        private IEnumerable<Coffee> _inputCoffeeList;

        public void AddListToDatabase(IEnumerable<Coffee> _inputCoffeeList)
        {
            //_inputCoffeeList = new List<Coffee>
            //{
            //    new Coffee {Country = "Costa Rica", IsDecaf = false, Strength = 4},
            //    new Coffee {Country = "India", IsDecaf = false, Strength = 3},
            //    new Coffee {Country = "Kenya", IsDecaf = true, Strength = 2}
            //};

            using (SqlConnection connection = new SqlConnection(_databaseConnectionString))
            {
                connection.Open();
                try
                {
                    connection.Execute("INSERT INTO Coffee VALUES (@Strength, @Country, @IsDecaf)", _inputCoffeeList);
                }
                catch (Exception exception)
                {
                    Debug.Print(exception.Message);
                    throw;
                }
                
            }
        }
    }
}
