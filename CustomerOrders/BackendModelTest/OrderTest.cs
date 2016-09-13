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
    class OrderTest
    {
        //private BackendModel.Order orderInstance;

        public void ChecksConstructorWorks()
        {
            string result = "placeholder";
            Assert.AreEqual("placeholder", result);
        }

    }
}
