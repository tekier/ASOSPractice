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
            _customerListTestObject = new CustomerList();
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
                    Id = 0,
                    Name = "Tawqir",
                    Orders = new List<Order>()
                }
            };

            _customerListTestObject.AddCustomer(testCustomerOperations);
            CustomerOperations retrievedCustomerOperations = _customerListTestObject.GetCustomer(1);
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
            CustomerOperations retrievedCustomerOperations = _customerListTestObject.GetCustomer(0);
            Assert.AreSame(testCustomerOperations, retrievedCustomerOperations);
        }

        [Test]
        public void TestNumberOfCustomers()
        {
            int numberOfCustomers = _customerListTestObject.NumberOfCustomers();
            Assert.AreEqual(2, numberOfCustomers);
        }
    }
}
