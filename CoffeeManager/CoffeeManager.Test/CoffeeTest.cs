using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [Test]
        public void TestThing()
        {
            SetUp();
            testMapper.DoNotCall();
        }
    }
}
