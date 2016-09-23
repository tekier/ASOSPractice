using System;
using System.Collections.Generic;
using System.IO;
using BackendModel;
using NUnit.Framework;

namespace BackendModelTest
{
    [TestFixture]
    class TestJsonIo
    {
        private string _path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "ApplicationData.json");
        private CustomerList _testCustomerList, _derivedTestCustomerList;
        private CustomerDetails _firstCustomerDetails, _secondCustomerDetails;
        private Order _firstTestOrder, _secondTestOrder, _thirdTestOrder, _fourthTestOrder;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _testCustomerList = new CustomerList
            {
                ListOfCustomers = new List<CustomerDetails>()
            };

            _firstCustomerDetails = new CustomerDetails
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

            _secondCustomerDetails = new CustomerDetails
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

            _firstTestOrder = new Order
            {
                Item = "suit",
                OrderId = 99,
                Quantity = 1
            };

            _secondTestOrder = new Order
            {
                Item = "coat",
                OrderId = 12,
                Quantity = 1
            };

            _thirdTestOrder = new Order
            {
                Item = "hat",
                OrderId = 900,
                Quantity = 5
            };

            _fourthTestOrder = new Order
            {
                Item = "cardigan",
                OrderId = 88,
                Quantity = 45
            };

        }

        [Test]
        public void TestJsonWriter()
        {
            _testCustomerList.AddCustomer(_firstCustomerDetails);
            _testCustomerList.AddCustomer(_secondCustomerDetails);
            _testCustomerList.AddNewOrder(_firstTestOrder, 18);
            _testCustomerList.AddNewOrder(_secondTestOrder, 18);
            _testCustomerList.AddNewOrder(_thirdTestOrder, 18);
            _testCustomerList.AddNewOrder(_fourthTestOrder, 7);
            _testCustomerList.ConvertToJson(_testCustomerList.ListOfCustomers, _path);

            Assert.IsTrue(File.Exists(_path));
            
        }

        [Test]
        public void TestJsonLoader()
        {
            _derivedTestCustomerList = new CustomerList();
            /*{
                ListOfCustomers = _testCustomerList.LoadJson()
            };*/
            _derivedTestCustomerList.LoadJson(_path);
            
            int numberOfCustomers = _derivedTestCustomerList.NumberOfCustomers();
            Assert.AreEqual(2, numberOfCustomers);

        }            

    }
}
