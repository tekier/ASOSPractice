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
    class TestJsonIO
    {
        private string path = "C:/Users/ahmed.sohail/Source/Repos/ASOSPractice/CustomerOrders/";
        private CustomerList _testCustomerList;
        private CustomerOperations firstCustomerOperations, secondCustomerOperations, derivedCustomerOperations;
        private Order firstTestOrder, secondTestOrder, thirdTestOrder, fourthTestOrder;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _testCustomerList = new CustomerList
            {
                ListOfCustomers = new List<CustomerOperations>()
            };

            firstCustomerOperations = new CustomerOperations
            {
                CustomerObject = new Customer
                {
                    CustomerAddress = new CustomerAddress
                    {
                        House = "Casa",
                        Postcode = "NW135T"
                    },
                    DateOfBirth = new DateTime(1994, 5, 5),
                    Id = 18,
                    Name = "Paul",
                    Orders = new List<Order>()
                }
            };

            secondCustomerOperations = new CustomerOperations
            {
                CustomerObject = new Customer
                {
                    CustomerAddress = new CustomerAddress
                    {
                        House = "Kieser",
                        Postcode = "AAABBB"
                    },
                    DateOfBirth = new DateTime(1993, 2, 1),
                    Id = 7,
                    Name = "Jimmy",
                    Orders = new List<Order>()
                }
            };

            firstTestOrder = new Order
            {
                Item = "scarf",
                OrderId = 99,
                Quantity = 1
            };

            secondTestOrder = new Order
            {
                Item = "coat",
                OrderId = 12,
                Quantity = 1
            };

            thirdTestOrder = new Order
            {
                Item = "hat",
                OrderId = 900,
                Quantity = 5
            };

            fourthTestOrder = new Order
            {
                Item = "cardigan",
                OrderId = 88,
                Quantity = 45
            };
            
        }

        [Test]
        public void TestJsonWriter()
        {
            _testCustomerList.AddCustomer(firstCustomerOperations);
            _testCustomerList.AddCustomer(secondCustomerOperations);
            _testCustomerList.AddNewOrder(firstTestOrder, 18);
            _testCustomerList.AddNewOrder(secondTestOrder, 18);
            _testCustomerList.AddNewOrder(thirdTestOrder,18);
            _testCustomerList.AddNewOrder(fourthTestOrder, 7);

            _testCustomerList.toJSON(_testCustomerList.ListOfCustomers, path);
            Assert.IsTrue(System.IO.File.Exists(path+"ApplicationData.json"));
        }

        [Test]
        public void TestJsonLoader()
        {
            Assert.True(true);
        }            

    }
}
