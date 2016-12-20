using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using TicTacToe.API;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class GameGridShould
    {
        private GameGrid _testGrid;
        [SetUp]
        public void SetUp()
        {
            _testGrid = new GameGrid(3);
        }

        [Test]
        public void ReturnArrayOfJustBlanksWhenInitialized()
        {
            var expectedArray = new[]
             {
                new[] {Moves.Blank, Moves.Blank, Moves.Blank},
                new[] {Moves.Blank, Moves.Blank, Moves.Blank},
                new[] {Moves.Blank, Moves.Blank, Moves.Blank}
            };
            _testGrid.Equals(expectedArray).Should().BeTrue();
        }
    }
}
