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
        Order testOrderObject = new Order(1, "socks", 4);

        public void ChecksConstructorWorks()
        {
            Order orderObject = new Order(2, "shirt", 2);
            Assert.AreSame(orderObject, orderObject.getInstance());
        }

        [Test]
        public void ChecksIdGetterWorkds()
        {
            int id = testOrderObject.getId();
            Assert.AreEqual(1, testOrderObject.getId());

        }

    }
}
