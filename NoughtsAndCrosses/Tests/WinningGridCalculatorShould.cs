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

        [TestCase(new[] {Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank}, false)]
        [TestCase(new[] {Moves.X, Moves.X, Moves.X, Moves.Blank, Moves.O, Moves.Blank, Moves.O, Moves.Blank, Moves.Blank }, true)]
        [TestCase(new[] {Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank, Moves.O, Moves.O, Moves.O }, true)]
        [TestCase(new[] {Moves.Blank, Moves.Blank, Moves.X, Moves.X, Moves.X, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank}, false)]
        public void CorrectlyDetectHorizantalWin(Moves[] fakeGameState, bool expectedBool)
        {
            bool actualBool = _testCalculator.Win(fakeGameState);
            actualBool.Should().Be(expectedBool);
        }
    }
}
