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
    [TestFixture]
    class CustomerListTest
    {
        private CustomerList _customerListTestObject;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _customerListTestObject = new CustomerList()
            {
                ListOfCustomers = new List<CustomerOperations>()
            };
        }

        [Test]
        public void TestingAddCustomerWorks()
        {
            CustomerOperations testCustomerOperations = new CustomerOperations
            {
                CustomerObject = new Customer
                {
                    CustomerAddress = new CustomerAddress
                    {
                        House = "Big House",
                        Postcode = "AAAAAA"
                    },
                    DateOfBirth = new DateTime(1995, 7, 21),
                    Id = 65,
                    Name = "Tawqir",
                    Orders = new List<Order>()
                }
            };

            _customerListTestObject.AddCustomer(testCustomerOperations);
            CustomerOperations retrievedCustomerOperations = _customerListTestObject.GetCustomer(65);
            Assert.AreSame(testCustomerOperations, retrievedCustomerOperations);
        }

        [Test]
        public void TestingAddAnotherCustomerWorks()
        {
            CustomerOperations testCustomerOperations = new CustomerOperations
            {
                CustomerObject = new Customer
                {
                    CustomerAddress = new CustomerAddress
                    {
                        House = "Teal House",
                        Postcode = "FUNFUN"
                    },
                    DateOfBirth = new DateTime(1991, 12, 1),
                    Id = 1,
                    Name = "Meah",
                    Orders = new List<Order>()
                }
            };

            _customerListTestObject.AddCustomer(testCustomerOperations);
            CustomerOperations retrievedCustomerOperations = _customerListTestObject.GetCustomer(1);
            Assert.AreSame(testCustomerOperations, retrievedCustomerOperations);
        }

        [Test]
        public void TestNumberOfCustomers()
        {
            int numberOfCustomers = _customerListTestObject.NumberOfCustomers();
            Assert.AreEqual(2, numberOfCustomers);
        }

        [Test]
        public void TestOrdersExistAndDoesNotExist()
        {
            Order testOrder = new Order
            {
                Item = "dress",
                OrderId = 70,
                Quantity = 3
            };
            Order newTestOrder = new Order
            {
                Item = "dice",
                OrderId = 34,
                Quantity = 100
            };
            _customerListTestObject.AddNewOrder(testOrder, 65);
            _customerListTestObject.AddNewOrder(newTestOrder, 1);
            Assert.IsNotEmpty(_customerListTestObject.GetCustomer(65).GetOrdersList());
            Assert.IsNotEmpty(_customerListTestObject.GetCustomer(1).GetOrdersList());
            Assert.AreEqual("dress", _customerListTestObject.GetCustomer(65).GetOrder(70).Item);
        }

        ////[Test]
        ////public void TestAddingAndGettingOrder()
        ////{
        ////    Order testOrder = new Order
        ////    {
        ////        Item = "watch",
        ////        OrderId = 23,
        ////        Quantity = 1
        ////    };
        ////    _customerListTestObject.AddNewOrder(testOrder, 1);
        ////    Assert.AreEqual(testOrder.Item, _customerListTestObject.GetCustomer(1).GetOrder(23));
        ////}
    }
}
