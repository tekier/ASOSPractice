using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BackendModel;

namespace BackendModelTest
{
    [TestFixture]
    class CustomerTest
    {
        Customer _customerTestObject = new Customer("Foo", new DateTime(1995, 7, 21));

        [Test]
        public void CheckNameSetterAndGetterWorks()
        {
            const string testString = "Tawqir";
            _customerTestObject.SetName(testString);
            Assert.AreEqual(testString, _customerTestObject.GetName());
        }

        [Test]
        public void CheckDOBGetterWorks()
        {
            DateTime dateOfBirth = _customerTestObject.GetDOB();
            Assert.AreEqual((new DateTime(1995, 7, 21)).ToString(CultureInfo.CurrentCulture), dateOfBirth.ToString(CultureInfo.CurrentCulture));

        }

        [Test]
        public void CheckDOBCalculatorWorks()
        {
            int age = _customerTestObject.GetCustomerAge();
            Assert.AreEqual(21, age);

        }
    
        [Test]
        public void TestOrderFirstAndSecondIndexInList()
        {
            Order testOrder = new Order(1, "shoes", 2);
            _customerTestObject.AddOrder(testOrder);
            Order retrievedTestOrder = _customerTestObject.GetOrder(0);
            Assert.AreSame(testOrder, retrievedTestOrder);
            Order newTestOrder = new Order(2, "vase", 1);
            _customerTestObject.AddOrder(newTestOrder);
            Order newRetrievedTestOrder = _customerTestObject.GetOrder(1);
            Assert.AreSame(newRetrievedTestOrder, _customerTestObject.GetOrder(1));

        }

        [Test]
        public void TestSizeOfList()
        {
            int length = _customerTestObject.GetNumberOfOrders();
            Assert.AreEqual(2, length);
        }

    }
}
