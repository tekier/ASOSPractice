using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API;
using FluentAssertions;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class GameShould
    {
        private Game _testGame;

        [SetUp]
        public void SetUp()
        {
            _testGame = new Game();
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 1)]
        [TestCase(0, 2, 2)]
        [TestCase(1, 0, 3)]
        [TestCase(1, 1, 4)]
        [TestCase(1, 2, 5)]
        [TestCase(2, 0, 6)]
        [TestCase(2, 1, 7)]
        [TestCase(2, 2, 8)]
        public void PositionCalculatorShould(int x, int y, int expectedPosition)
        {
            int actualCalculatedPosition = _testGame.CalculatePosition(x, y);
            actualCalculatedPosition.Should().Be(expectedPosition);
        }
    }
}
