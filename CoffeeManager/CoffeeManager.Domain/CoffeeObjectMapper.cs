using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using CoffeeManager.Contracts;
using Dapper;

namespace CoffeeManager.Domain
{
    public class CoffeeObjectMapper
    {
        private const string DatabaseConnectionString =
            "Data Source=ASGLH-WL-11919;Initial Catalog=CoffeeDatabase;Integrated Security=True";

        private readonly IEnumerable<Coffee> _inputCoffeeList = new List<Coffee>();

        public List<Coffee> GetCoffeeListFromDatabase(string sql = "SELECT * FROM Coffee")
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnectionString))
            {
                return connection.Query<Coffee>(sql).ToList();
            }
        }
        public void AddToInputList(Coffee coffee)
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            _inputCoffeeList.Concat(new[] {coffee});
        }
        public void AddListToDatabase(IEnumerable<Coffee> inputCoffeeList)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnectionString))
            {
                connection.Open();
                try
                {
                    connection.Execute("INSERT INTO Coffee VALUES (@Strength, @Country, @IsDecaf)", inputCoffeeList);
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
