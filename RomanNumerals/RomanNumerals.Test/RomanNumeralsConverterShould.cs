using System;
using FluentAssertions;
using NUnit.Framework;
using RomanNumerals.API;

namespace RomanNumerals.Test
{
    [TestFixture]
    public class RomanNumeralsConverterShould
    {
        private Converter _converter;

        [SetUp]
        public void SetUp()
        {
            _converter = new Converter();
        }

        [TestCase(454, "CDLIV")]
        [TestCase(1000, "M")]
        [TestCase(1001, "MI")]
        [TestCase(9994, "MMMMMMMMMCMXCIV")]
        [TestCase(10000, "MMMMMMMMMM")]
        public void ReturnRomanNumeralForInputInteger(int input, string expectedResult)
        {
            string actualResult = _converter.GetRomanNumeralRepresentationOf(input);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void ThrowExceptionWithNumbersLessThanOne()
        {
            Action invalidAction = () => _converter.GetRomanNumeralRepresentationOf(-1);
            invalidAction.ShouldThrow<Exception>().WithMessage("Numbers less than 1 not supported.");
        }
        [Test]
        public void ThrowExceptionWithNumbersLargerThanTenThousand()
        {
            Action invalidAction = () => _converter.GetRomanNumeralRepresentationOf(10001);
            invalidAction.ShouldThrow<Exception>().WithMessage("Number too big.");
        }
    }
}
