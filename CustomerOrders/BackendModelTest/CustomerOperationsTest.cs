using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendModel;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace BackendModelTest
{
    class CustomerOperationsTest
    {
        private CustomerOperations _customerOperationsTestObject;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _customerOperationsTestObject = new CustomerOperations
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
            int age = _customerOperationsTestObject.GetCustomerAge();
            Assert.AreEqual(21, age);
        }

        [Test]
        public void TestOrderFirstIndexInList()
        {
            Order testOrder = new Order
            {
                _item = "shoes",
                _orderId = 1,
                _quantity = 2
            };
            _customerOperationsTestObject.AddOrder(testOrder);
            Order retrievedTestOrder = _customerOperationsTestObject.GetOrder(0);
            Assert.AreSame(testOrder, retrievedTestOrder);
        }

        [Test]
        public void TestOrderSecondIndexInList()
        {
            Order testOrder = new Order
            {
                _item = "lamp",
                _orderId = 23,
                _quantity = 1
            };
            _customerOperationsTestObject.AddOrder(testOrder);
            Order retrievedTestOrder = _customerOperationsTestObject.GetOrder(1);
            Assert.AreSame(testOrder,retrievedTestOrder);
        }

        [Test]
        public void TestSizeOfList()
        {
            int length = _customerOperationsTestObject.GetNumberOfOrders();
            Assert.AreEqual(2, length);
        }
    }
}
