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

        [Test]
        public void ReturnsBuzz_WhenEntered_Five()
        {
            Fizzbuzz fizzbuzz = new Fizzbuzz();

            string result = fizzbuzz.Process(5);

            Assert.AreEqual("Buzz", result);

        }
    }
}
