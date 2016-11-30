using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [Test]
        public void CheckIfScoreStringIsValid()
        {
            var result = _calculator.VerifyString("X|X|X|X|X|X|X|X|X|X||XX");
            result.Should().BeTrue();
        }
    }
}
