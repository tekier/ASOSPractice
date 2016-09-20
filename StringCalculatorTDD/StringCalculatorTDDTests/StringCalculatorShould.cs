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

        [TestCase("0,1", 1)]
        [TestCase("1,1", 2)]
        [TestCase("2,1", 3)]
        public void ReturnSumOfInputStringOfNumbersSeperatedByCommas(string inputString, int expectedResult)
        {
            int result = StringCalculator.Calculate(inputString);
            result.Should().Be(expectedResult);
        }

        [Test]
        public void ReturnSumOfInputStringOfNumbersSeperateedByCommasWithMissingNumbers()
        {
            int result = StringCalculator.Calculate("1,,0");
            result.Should().Be(1);
        }
        
        //[Test]
        //public void ReturnSumOfInputStringOfNumbers
    }
}
