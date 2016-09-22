using NUnit.Framework;
using BackendModel;

namespace BackendModelTest
{
    [TestFixture]
    class OrderTest
    {
      
        private Order _testOrderObject;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _testOrderObject = new Order()
            {
                OrderId = 1,
                Item = "socks",
                Quantity = 4
            };
        }

        [Test]
        public void ChecksIdGetterWorkds()
        {
            int id = _testOrderObject.OrderId;
            Assert.AreEqual(1, _testOrderObject.OrderId);

        }

        [Test]
        public void ChecksItemGetterWorks()
        {
            string item = _testOrderObject.Item;
            Assert.AreEqual("socks", _testOrderObject.Item);

        }

        [Test]
        public void ChecksQuantityGetterWorks()
        {
            int quantity = _testOrderObject.Quantity;
            Assert.AreEqual(4, _testOrderObject.Quantity);
        }

    }
}
