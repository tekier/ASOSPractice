using System;
using System.Collections.Generic;
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
        readonly Customer _customerTestObject = new Customer("Foo", new DateTime(1995, 7, 21), 'm');

        [Test]
        public void CheckNameSetterAndGetterWorks()
        {
            const string testString = "Tawqir";
            _customerTestObject.SetName(testString);
            Assert.AreEqual(testString, _customerTestObject.GetName());
        }

    }
}
