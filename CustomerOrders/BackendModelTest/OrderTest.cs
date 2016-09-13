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
        readonly Order _testOrderObject = new Order(1, "socks", 4);
        
        [Test]
        public void ChecksConstructorWorks()
        {
            Order orderObject = new Order(2, "shirt", 2);
            Assert.AreSame(orderObject, orderObject.GetInstance());
        }

        [Test]
        public void ChecksIdGetterWorkds()
        {
            int id = _testOrderObject.GetId();
            Assert.AreEqual(1, _testOrderObject.GetId());

        }

        [Test]
        public void ChecksItemGetterWorks()
        {
            string item = _testOrderObject.GetItemName();
            Assert.AreEqual("socks", _testOrderObject.GetItemName());

        }

        [Test]
        public void ChecksQuantityGetterWorks()
        {
            int quantity = _testOrderObject.GetQuantity();
            Assert.AreEqual(4, _testOrderObject.GetQuantity());
        }

    }
}
