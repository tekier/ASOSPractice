using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CoffeeApiClient.ClientApi;
using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NUnit.Framework;

namespace CoffeeApiClient.ClientApiTest
{
    [TestFixture]
    class CoffeeClientShould
    {
        private CoffeeClient _testClient;

        [SetUp]
        public void SetUp()
        {
            _testClient = new CoffeeClient();
        }

        [TestCase(1, "[{\"Id\":1,\"Strength\":4,\"Country\":\"Costa Rica\",\"IsDecaf\":false}]")]
        [TestCase(3, "[{\"Id\":3,\"Strength\":2,\"Country\":\"Kenya\",\"IsDecaf\":true}]")]
        public void ReturnCorrectJsonStringWhenCoffeeObjectIsRequestedById(int id, string expectedResult)
        {
            string actualResult = _testClient.GetCoffeeFromApiById(id).Result;
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void ReturnCorrectNothingWhenCoffeeObjectDoesntExist()
        {
            string actualResult = _testClient.GetCoffeeFromApiById(55).Result;
            string expectedResult = "[]";
            actualResult.Should().Be(expectedResult);
        }
    }
}
