using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using CoffeeManager.Contracts;
using Dapper;

namespace CoffeeManager.Domain
{
    public class CoffeeRepository
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        private readonly IEnumerable<Coffee> _inputCoffeeList = new List<Coffee>();

        public List<Coffee> GetCoffeeList(string selectQuery = "SELECT * FROM Coffee")
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Coffee>(selectQuery).ToList();
            
            }
        }

        public List<Coffee> GetCoffeeList(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Coffee>(String.Concat("SELECT * FROM Coffee WHERE Id = ", id)).ToList();
            }
        }
        public void AddCoffeeBeforeInput(Coffee coffee)
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            _inputCoffeeList.Concat(new[] {coffee});
        }
        public void AddCoffeeList(IEnumerable<Coffee> inputCoffeeList)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                try
                {
                    connection.Execute("INSERT INTO Coffee VALUES (@Strength, @Country, @IsDecaf)", inputCoffeeList);
                }
                catch (Exception exception)
                {
                    Debug.Print(exception.Message);
                }
                
            }
        }
    }
}
