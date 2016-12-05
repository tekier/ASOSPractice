using Bowling.API;
using FluentAssertions;
using NUnit.Framework;

namespace Bowling.Tests
{
    [TestFixture]
    public class BowlingCalculatorShould
    {
        private ScoreCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new ScoreCalculator();
        }

        [TestCase("X|X|X|X|X|X|X|X|X|X||XX")]
        [TestCase("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||")]
        [TestCase("X|7/|9-|X|-8|8/|-6|X|X|X||81")]
        public void VerifyScoreStringHasValidNumberOfFrames(string inputString)
        {
            var result = _calculator.VerifyCorrectNumberOfFrames(inputString);
            result.Should().BeTrue();
        }

        [Test]
        public void VerifyInvalidScoreStringHasInvalidNumberOfFrames()
        {
            var result = _calculator.VerifyCorrectNumberOfFrames("X|X|X|X|X|X|X|X|X||XX");
            result.Should().BeFalse();
        }

        [TestCase("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        [TestCase("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", 90)]
        [TestCase("-5|-3|-7|-1|-9|-5|-4|-2|-3|-6||", 45)]
        [TestCase("X|X|X|X|X|-4|X|X|X|X||XX", 248)]
        public void CalculateCorrectScoreForGivenInputString(string inputString, int expectedResult)
        {
            var resultFromCalculator = _calculator.CalculateScore(inputString);
            resultFromCalculator.Should().Be(expectedResult);
        }
    }
}
