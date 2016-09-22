using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;
using BackendModel;

namespace BackendModelTest
{
    [TestFixture]
    class CustomerTest
    {
        private Customer _customerTestObject;
        
        [TestFixtureSetUp]
        public void SetUp()
        {
            _customerTestObject = new Customer
            {
                Id = 1,
                Name = "NONAME",
                CustomerAddress = new CustomerAddress
                {
                    House = "64",
                    Postcode = "TW20 0PW"
                },
                DateOfBirth = new DateTime(1995,7,21),
                Orders = new List<Order>()

            };
        }


        [Test]
        public void CheckNameSetterAndGetterWorks()
        {
            const string testString = "Tawqir";
            _customerTestObject.Name = testString;
            Assert.AreEqual(testString, _customerTestObject.Name);
        }

        [Test]
        public void CheckDobGetterWorks()
        {
            DateTime dateOfBirth = _customerTestObject.DateOfBirth;
            Assert.AreEqual((new DateTime(1995, 7, 21)).ToString(CultureInfo.CurrentCulture), dateOfBirth.ToString(CultureInfo.CurrentCulture));

        }
    }
}
