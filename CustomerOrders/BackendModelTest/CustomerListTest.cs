using System;
using System.Collections.Generic;
using BackendModel;
using NUnit.Framework;

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
                ListOfCustomers = new List<CustomerDetails>()
            };
        }

        [Test]
        public void TestingAddCustomerWorks()
        {
            CustomerDetails testCustomerDetails = new CustomerDetails
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

            _customerListTestObject.AddCustomer(testCustomerDetails);
            CustomerDetails retrievedCustomerDetails = _customerListTestObject.GetCustomer(65);
            Assert.AreSame(testCustomerDetails, retrievedCustomerDetails);
        }

        [Test]
        public void TestingAddAnotherCustomerWorks()
        {
            CustomerDetails testCustomerDetails = new CustomerDetails
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

            _customerListTestObject.AddCustomer(testCustomerDetails);
            CustomerDetails retrievedCustomerDetails = _customerListTestObject.GetCustomer(1);
            Assert.AreSame(testCustomerDetails, retrievedCustomerDetails);
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
            _customerListTestObject.AddNewOrder(newTestOrder, 1);
            _customerListTestObject.AddNewOrder(testOrder, 65);
            Assert.IsNotEmpty(_customerListTestObject.GetCustomer(65).GetOrdersList());
            Assert.AreEqual("dress", _customerListTestObject.GetCustomer(65).GetOrder(70).Item);
            Assert.IsNotEmpty(_customerListTestObject.GetCustomer(1).GetOrdersList());
            Assert.AreEqual(2, _customerListTestObject.GetCustomer(1).GetNumberOfOrders());
        }

        [Test]
        public void TestOrderIsTheSame()
        {
            Order testOrder = new Order
            {
                Item = "watch",
                OrderId = 21,
                Quantity = 7
            };

            _customerListTestObject.AddNewOrder(testOrder, 1);
            Assert.AreSame(testOrder, _customerListTestObject.GetCustomer(1).GetOrder(21));
        }
    }
}
