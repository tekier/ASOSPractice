using NUnit.Framework;
using BackendModel;

namespace BackendModelTest
{
    [TestFixture]
    class CustomerAddressTest
    {
        private CustomerAddress _testCustomerAddressObject;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _testCustomerAddressObject = new CustomerAddress
            {
                House = "64",
                Postcode = "XXXXXX"
            };
        }

        [Test]
        public void CheckHouseSetterAndGetterWorks()
        {
            const string testString = "Lesser London House";
            _testCustomerAddressObject.House = testString;
            Assert.AreEqual(testString, _testCustomerAddressObject.House);
        }

        [Test]
        public void CheckPostcodeSetterandGetterWorks()
        {
            const string testString = "XXXXXX";
            _testCustomerAddressObject.Postcode = testString;
            Assert.AreEqual(testString, _testCustomerAddressObject.Postcode);

        }


    }
}
