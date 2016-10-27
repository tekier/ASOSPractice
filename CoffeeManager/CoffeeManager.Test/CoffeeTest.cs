using System.Collections.Generic;
using System.Linq;
using CoffeeManager.Contracts;
using NUnit.Framework;
using CoffeeManager.Domain;

namespace CoffeeManager.Test
{
    [TestFixture]
    class CoffeeTest
    {
        private CoffeeObjectMapper _testMapper;
#pragma warning disable 618
        [TestFixtureSetUp]
#pragma warning restore 618
        public void SetUp()
        {
            _testMapper = new CoffeeObjectMapper();
        }

        [Test]
        public void FirstEntryFromListOfCoffeesShouldCorrectlyBeReturnedFromDb()
        {
            IEnumerable<Coffee> testList = _testMapper.GetCoffeeListFromDatabase();
            string expectedOutput = "Costa Rica";
            string actualOutput = testList.First().Country;
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void LastEntryFromListOfCoffeesShouldCorrectlyBeReturnedFromDb()
        {
            IEnumerable<Coffee> testList = _testMapper.GetCoffeeListFromDatabase();
            bool actualOutput = testList.Last().IsDecaf;
            Assert.IsFalse(actualOutput);
        }
    }
}
