using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeManager.Contracts;
using NUnit.Framework;
using CoffeeManager.Domain;

namespace CoffeeManager.Test
{
    [TestFixture]
    class CoffeeTest
    {
        private CoffeeObjectMapper testMapper;
        [TestFixtureSetUp]
        public void SetUp()
        {
            testMapper = new CoffeeObjectMapper();
        }

        //[Test]
        //public void TestThing()
        //{
        //    SetUp();
        //    testMapper.DoNotCall();
        //}

        [Test]
        public void FirstEntryFromListOfCoffeesShouldCorrectlyBeReturnedFromDb()
        {
            IEnumerable<Coffee> testList = testMapper.GetCoffeeListFromDatabase();
            string expectedOutput = "Costa Rica";
            string actualOutput = testList.First().Country;
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void LastEntryFromListOfCoffeesShouldCorrectlyBeReturnedFromDb()
        {
            IEnumerable<Coffee> testList = testMapper.GetCoffeeListFromDatabase();
            bool expectedOutput = true;
            bool actualOutput = testList.Last().IsDecaf;
            Assert.IsTrue(expectedOutput && actualOutput);
        }
    }
}
