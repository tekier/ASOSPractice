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
                Item = "shoes",
                OrderId = 1,
                Quantity = 2
            };
            _customerOperationsTestObject.AddOrder(testOrder);
            Order retrievedTestOrder = _customerOperationsTestObject.GetOrder(1);
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
            _customerOperationsTestObject.AddOrder(testOrder);
            Order retrievedTestOrder = _customerOperationsTestObject.GetOrder(23);
            Assert.AreSame(testOrder,retrievedTestOrder);
        }

        [Test]
        public void TestSizeOfList()
        {
            int length = _customerOperationsTestObject.GetNumberOfOrders();
            Assert.AreEqual(2, length);
        }

        //[Test]
        //public void TestJsonSerializerWorks()
        //{
        //    const string path = "C:/Users/ahmed.sohail/Source/Repos/ASOSPractice/CustomerOrders/BackendModelTest/ApplicationInfo.json";
        //    _customerOperationsTestObject.toJSON(_customerOperationsTestObject.CustomerObject, path);
        //    string testJson = JsonConvert.SerializeObject(_customerOperationsTestObject.CustomerObject, Formatting.Indented);
        //    string info = System.IO.File.ReadAllText(path);
        //    Assert.AreEqual(testJson, info);
        //}

        //[Test]
        //public void TestJsonDeserializerWorkds()
        //{
        //    const string path = "C:/Users/ahmed.sohail/Source/Repos/ASOSPractice/CustomerOrders/BackendModelTest/ApplicationInfo.json";
        //    _customerOperationsTestObject.parseJSON(_customerOperationsTestObject);
        //}
    }
}
