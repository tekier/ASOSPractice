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
        readonly Customer CustomerTestObject = new Customer("Foo", new DateTime(1995, 7, 21), 'm');

    }
}
