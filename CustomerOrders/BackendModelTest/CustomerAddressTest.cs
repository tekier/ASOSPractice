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
        private readonly CustomerAddress _testCustomerAddressObject = new CustomerAddress("Greater London House", "SA27AP");

        [Test]
        public void CheckHouseSetterAndGetterWorks()
        {
            const string testString = "Lesser London House";
            _testCustomerAddressObject.SetHouse(testString);
            Assert.AreEqual(testString, _testCustomerAddressObject.GetHouse());
        }

        [Test]
        public void CheckPostcodeSetterandGetterWorks()
        {
            const string testString = "XXXXXX";
            _testCustomerAddressObject.SetPostcode(testString);
            Assert.AreEqual(testString, _testCustomerAddressObject.GetPostcode());

        }


    }
}
