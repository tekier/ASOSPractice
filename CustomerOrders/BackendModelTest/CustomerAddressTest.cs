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
    class CustomerAddressTest
    {
        CustomerAddress _TestCustomerAddressObject = new CustomerAddress("Greater London House", "SA27AP");

        [Test]
        public void CheckHouseSetterAndGetterWorks()
        {
            const string testString = "Lesser London House";
            _TestCustomerAddressObject.SetHouse(testString);
            Assert.AreEqual(testString, _TestCustomerAddressObject.GetHouse());
        }


    }
}
