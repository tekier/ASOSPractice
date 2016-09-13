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

        public void ChecksConstructorWorks()
        {
            Order orderObject = new Order(1, "socks", 2);
            Assert.AreSame(orderObject, orderObject.getInstance());
        }

    }
}
