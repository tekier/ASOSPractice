using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzbuzzTest
{
    [TestFixture]
    class FizzbuzzTests
    {
        [Test]

        public void ReturnsOne_WhenEntered_One()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();

            string result = fizzbuzz.Process(1);

            Assert.AreEqual("1", result);
        }

        [Test]
        public void ReturnsFizz_WhenEntered_Three()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();

            string result = fizzbuzz.Process(3);

            Assert.AreEqual("Fizz", result);
        }
        
    }
}
