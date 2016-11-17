using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingScoreCalculator;
using FluentAssertions;
using NUnit.Framework;

namespace BowlingScoreCalculatorTest
{
    [TestFixture]
    class BowlingCalculatorShould
    {
        private BowlingScoreCalc _calculator;
        [SetUp]
        public void SetUp()
        {
            _calculator = new BowlingScoreCalc();
        }

        [TestCase("--|--|--|--|--|--|--|--|--|--||", 0)]
        [TestCase("11|--|--|--|--|--|--|--|--|--||", 2)]
        [TestCase("11|--|--|--|--|--|33|--|--|--||", 8)]
        public void ReturnZeroIfAllStrikesMissed(string input, int expectedResult)
        {
            int result = _calculator.CalculateScore(input);
            result.Should().Be(expectedResult);

        }

    }
}
