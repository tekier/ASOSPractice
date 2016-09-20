using System.Security.Cryptography.X509Certificates;
using FluentAssertions;
using NUnit.Framework;
using StringCalculatorTDD;

namespace StringCalculatorTDDTests
{
    [TestFixture]
    class StringCalculatorShould
    {
        [Test]
        public void ReturnZero_GivenAnEmptyString()
        {
            var result = StringCalculator.Calculate("");

            result.Should().Be(0);
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        public void ReturnIntegerRepresentationOfInputString(string inputString, int expectedResult)
        {
            var result = StringCalculator.Calculate(inputString);

            result.Should().Be(expectedResult);
        }

        [Test]
        public void ReturnSumOfInputStringZeroCommaOneAsInteger()
        {
            var result = StringCalculator.Calculate("0,1");

            result.Should().Be(1);
        }

        [Test]
        public void ReturnSumOfInputStringOneCommaOneAsInteger()
        {
            var result = StringCalculator.Calculate("1,1");

            result.Should().Be(2);
        }

        [Test]
        public void ReturnSumOfInputStringOneCommaTwoAsInteger()
        {
            var result = StringCalculator.Calculate("1,2");

            result.Should().Be(3);
        }
    }
}
