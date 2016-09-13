using NUnit.Framework;

namespace FizzbuzzTest
{
    [TestFixture]
    class FizzbuzzTests
    {
        Fizzbuzz fizzbuzz = new Fizzbuzz();

        [Test]
        public void ReturnsOne_WhenEntered_One()
        {
            string result = fizzbuzz.Process(1);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void ReturnsFizz_WhenEntered_Three()
        {
            string result = fizzbuzz.Process(3);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void ReturnsBuzz_WhenEntered_Five()
        {
            string result = fizzbuzz.Process(5);
            Assert.AreEqual("Buzz", result);

        }

        [Test]
        public void ReturnsFizzBuzz_WhenEntered_Fifteen()
        {
            string result = fizzbuzz.Process(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void ReturnsFizz_WhenEntered_MultiplesOfThree()
        {
            string result = fizzbuzz.Process(21);
            Assert.AreEqual("Fizz", result);

        }

        [Test]
        public void ReturnsBuzz_WhenEntered_MultiplesOfFive()
        {
            string result = fizzbuzz.Process(25);
            Assert.AreEqual("Buzz", result);
        }
    }
}
