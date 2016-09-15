using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BackendModel;

namespace BackendModelTest
{
    [TestFixture]
    class OrderTest
    {
        //Constructor
        private Order _testOrderObject;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _testOrderObject = new Order()
            {
                _orderId = 1,
                _item = "socks",
                _quantity = 4
            };
        }

        [Test]
        public void ChecksIdGetterWorkds()
        {
            int id = _testOrderObject._orderId;
            Assert.AreEqual(1, _testOrderObject._orderId);

        }

        [Test]
        public void ChecksItemGetterWorks()
        {
            string item = _testOrderObject._item;
            Assert.AreEqual("socks", _testOrderObject._item);

        }

        [Test]
        public void ChecksQuantityGetterWorks()
        {
            int quantity = _testOrderObject._quantity;
            Assert.AreEqual(4, _testOrderObject._quantity);
        }

    }
}
