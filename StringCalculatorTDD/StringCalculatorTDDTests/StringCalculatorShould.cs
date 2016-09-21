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

        [TestCase("1,,0",1)]
        [TestCase("1,1,",2)]
        [TestCase(",0,1",1)]
        public void ReturnSumOfInputStringOfNumbersSeperatedByCommasWithMissingNumbers(string inputString, int expectedResult)
        {
            int result = StringCalculator.Calculate(inputString);
            result.Should().Be(expectedResult);
        }

        [TestCase("1,0,1",2)]
        [TestCase("1,1,2,3",7)]
        [TestCase("25,75,1,8,0,1", 110)]
        public void ReturnSumOfInputStringOfMoreThanTwoNumbersSeperatedByCommas(string inputString, int expectedResult)
        {
            int result = StringCalculator.Calculate(inputString);

            result.Should().Be(expectedResult);
        }

        [TestCase("5,,,2",7)]
        [TestCase("3,2,,5,,,7",17)]
        [TestCase(",,,,,,,,,,,,,,,,,,",0)]
        [TestCase("",0)]
        public void ReturnSumOfInputStringOfMoreThanTwoNumbersSeperatedByCommasWithMissingNumbers(string inputString,int expectedResult)
        {
            int result = StringCalculator.Calculate(inputString);

            result.Should().Be(expectedResult);
        }

        [TestCase("%%FGASFDFsdfq34uilf;asdfasdfiluawylevfba")]
        [TestCase(",,3145adsf,qdfasf=asdf,,====,,,")]
        [TestCase("\n\n\n\t\n")]
        [TestCase("\x00,\x56,\x56")]
        public void ReturnZeroWithUnexpectedInputStrings(string inputString)
        {
            int result = StringCalculator.Calculate(inputString);

            result.Should().Be(0);
        }

        [TestCase("6,six,five,four,eighteen,44",50)]
        [TestCase("Q3409RY0934w785w^^,6q3,qwervas,000000000000,x7,8,,,,,", 8)]
        [TestCase("455555.4343,3", 3)]
        [TestCase("4.0,5.4,5,souppppppppp5pp4,1", 6)]
        [TestCase("4.5,0.8",0)]
        public void ReturnCorrectResultWithMixedStringsContainingNumbersAndRandomCharactersSeperatedByCommas(
            string inputString, int expectedResult)
        {
            int result = StringCalculator.Calculate(inputString);

            result.Should().Be(expectedResult);
        }


    }
}
