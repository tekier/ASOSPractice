using CoffeeApiClient.ClientApi;
using FluentAssertions;
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
            string actualResult = _testClient.GetCoffeeById(id).Result;
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void ReturnEmptyJsonObjectWhenCoffeeObjectDoesntExist()
        {
            string actualResult = _testClient.GetCoffeeById(55).Result;
            string expectedResult = "[]";
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void ReturnFullListOfCoffeesWhenGetAllCoffeesIsCalled()
        {
            string actualResult = _testClient.GetAllCoffees().Result;
            string expectedResult =
                "[{\"Id\":1,\"Strength\":4,\"Country\":\"Costa Rica\",\"IsDecaf\":false},{\"Id\":2,\"Strength\":3,\"Country\":\"India\",\"IsDecaf\":false},{\"Id\":3,\"Strength\":2,\"Country\":\"Kenya\",\"IsDecaf\":true},{\"Id\":4,\"Strength\":5,\"Country\":\"Indonesia\",\"IsDecaf\":false}]";
            actualResult.Should().Be(expectedResult);
        }
    }
}
