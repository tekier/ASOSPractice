using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingGame.Calculator;
using FluentAssertions;
using NUnit.Framework;

namespace BowlingGame.Test
{
    [TestFixture]
    public class BowlingScoreCalculatorShould
    {
        private ScoreCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new ScoreCalculator();
        }

        [Test]
        public void ReturnNothingForEmptyInput()
        {
            var scoreString = "";
            Action actionToDo = () => _calculator.CalculateScore(scoreString);
            actionToDo.ShouldThrow<Exception>();
        }

        [TestCase("10,10,10,10,10,10,10,10,10,10,10,10", 300)]
        //[TestCase("9,0,9,0,9,0,9,0,9,0,9,0,9,0,9,0,9,0,9,0", 90)]
        public void ReturnCorrectScoreForValidInput(string scoreInput, int expectedResult)
        {
            var actualResult = _calculator.CalculateScore(scoreInput);
            actualResult.Should().Be(expectedResult);
        }

    }
}
