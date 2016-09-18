using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using BackendModel;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace BackendModelTest
{
    [TestFixture]
    class TestJsonIO
    {
        private string path = Path.Combine(Directory.GetCurrentDirectory(), "ApplicationData.json");
        //"C:/Users/ahmed.sohail/Source/Repos/ASOSPractice/CustomerOrders/";
        private CustomerList _testCustomerList, _derivedTestCustomerList;
        private CustomerDetails _firstCustomerDetails, _secondCustomerDetails;
        private Order firstTestOrder, secondTestOrder, thirdTestOrder, fourthTestOrder;

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

            firstTestOrder = new Order
            {
                Item = "suit",
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
            _testCustomerList.AddCustomer(_firstCustomerDetails);
            _testCustomerList.AddCustomer(_secondCustomerDetails);
            _testCustomerList.AddNewOrder(firstTestOrder, 18);
            _testCustomerList.AddNewOrder(secondTestOrder, 18);
            _testCustomerList.AddNewOrder(thirdTestOrder, 18);
            _testCustomerList.AddNewOrder(fourthTestOrder, 7);

            _testCustomerList.ToJSON(_testCustomerList.ListOfCustomers, path);
            Assert.IsTrue(System.IO.File.Exists(path));
            
        }

        [Test]
        public void TestJsonLoader()
        {
            _derivedTestCustomerList = new CustomerList()
            {
                ListOfCustomers = _testCustomerList.LoadJson(path)
            };
            int numberOfCustomers = _derivedTestCustomerList.NumberOfCustomers();
            Assert.AreEqual(2, numberOfCustomers);

        }            

    }
}
