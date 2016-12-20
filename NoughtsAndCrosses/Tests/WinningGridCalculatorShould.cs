using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class WinningGridCalculatorShould
    {
        private WinningGridCalculator _testCalculator;

        [SetUp]
        public void SetUp()
        {
            _testCalculator = new WinningGridCalculator();
        }

        [Test]
        public void CorrectlyDetectHorizantalWinForCaseOne()
        {
            Moves[] fakeGameState = {
                Moves.Blank, Moves.Blank, Moves.Blank, Moves.X, Moves.X, Moves.X, Moves.Blank, Moves.Blank, Moves.Blank
            };
            bool actualBool = _testCalculator.HorizontalWin(fakeGameState);
            actualBool.Should().BeTrue();
        }

        [Test]
        public void CorrectlyNotDetectHorizantalWinForCaseTwo()
        {
            Moves[] fakeGameState = {
                Moves.Blank, Moves.Blank, Moves.X, Moves.X, Moves.X, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank
            };
            bool actualBool = _testCalculator.HorizontalWin(fakeGameState);
            actualBool.Should().BeFalse();
        }


    }
}
