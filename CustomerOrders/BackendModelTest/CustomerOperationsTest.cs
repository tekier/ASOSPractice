using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendModel;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace BackendModelTest
{
    [TestFixture]
    class CustomerOperationsTest
    {
        private CustomerDetails _customerDetailsTestObject;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _customerDetailsTestObject = new CustomerDetails
            {
                CustomerObject = new Customer
                {
                    Name = "Tawqir",
                    CustomerAddress = new CustomerAddress
                    {
                        House = "64",
                        Postcode = "TW20 0PW"
                    },
                    DateOfBirth = new DateTime(1995, 7, 21),
                    Orders = new List<Order>(),
                }
            };
        }

        [Test]
        public void CheckDobCalculatorWorks()
        {
            int age = _customerDetailsTestObject.GetCustomerAge();
            Assert.AreEqual(21, age);
        }

        [Test]
        public void TestOrderFirstIndexInList()
        {
            Order testOrder = new Order
            {
                Item = "shoes",
                OrderId = 1,
                Quantity = 2
            };
            _customerDetailsTestObject.AddOrder(testOrder);
            Order retrievedTestOrder = _customerDetailsTestObject.GetOrder(1);
            Assert.AreSame(testOrder, retrievedTestOrder);
        }

        [Test]
        public void TestOrderSecondIndexInList()
        {
            Order testOrder = new Order
            {
                Item = "lamp",
                OrderId = 23,
                Quantity = 1
            };
            _customerDetailsTestObject.AddOrder(testOrder);
            Order retrievedTestOrder = _customerDetailsTestObject.GetOrder(23);
            Assert.AreSame(testOrder,retrievedTestOrder);
        }

        [Test]
        public void TestSizeOfList()
        {
            int length = _customerDetailsTestObject.GetNumberOfOrders();
            Assert.AreEqual(2, length);
        }

    }
}
