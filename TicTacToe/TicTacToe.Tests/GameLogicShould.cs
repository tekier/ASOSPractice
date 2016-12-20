using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using TicTacToe.API;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeGameLogicShould
    {
        private GameLogic _game;
        private Moves[][] _testingGrid;

        [SetUp]
        public void SetUp()
        {
            _game = new GameLogic();
            _testingGrid = new[]
            {
                new[] {Moves.O, Moves.Blank, Moves.O},
                new[] {Moves.X, Moves.X, Moves.O},
                new[] {Moves.Blank, Moves.Blank, Moves.X}
            };
            _game.SetGrid(_testingGrid);
        }

        [TestCase(0, 0, Moves.O)]
        [TestCase(1, 1, Moves.X)]
        [TestCase(2, 1, Moves.Blank)]
        public void GetTheElementFromTheIndexIThinkItIsAt(int row, int column, Moves expectedMove)
        {
            var actualMove = _game.GetElementAt(row, column);
            actualMove.ShouldBeEquivalentTo(expectedMove);
        }

        [TestCase(0, 0)]
        [TestCase(0, 1)]
        [TestCase(0, 2)]
        public void CorrectlyReturnFalseForOutOfBoundRequestToGetGridPostionAboveArbitraryPostion(int row, int column)
        {
            var expectedBoolean = _game.CheckMoveAboveIs(row, column, Moves.O);
            expectedBoolean.Should().BeFalse();
        }

        [TestCase(1, 1, Moves.Blank)]
        [TestCase(1, 2, Moves.O)]
        [TestCase(2, 0, Moves.X)]
        public void CorrectlyReturnTrueForRequestToGetGridPostionAboveArbitraryPosition(int row, int column, Moves expectedMove)
        {
            var expectedBoolean = _game.CheckMoveAboveIs(row, column, expectedMove);
            expectedBoolean.Should().BeTrue();
        }

        [TestCase(1,0)]
        [TestCase(2,0)]
        public void CorrectlyReturnFalseForOutOfBoundRequestToGetGridPostitionToTheLeftOfArbitraryPosition(int row, int column)
        {
            var expectedBoolean = _game.CheckMoveOnLeftIs(row, column, Moves.Blank);
            expectedBoolean.Should().BeFalse();
        }

        [TestCase(2, 1, Moves.Blank)]
        [TestCase(1, 2, Moves.X)]
        [TestCase(0, 1, Moves.O)]
        public void CorrectlyReturnTrueForRequestToGetGridPostionToTheLeftOfArbitraryPosition(int row, int column, Moves expectedMove)
        {
            var expectedBoolean = _game.CheckMoveOnLeftIs(row, column, expectedMove);
            expectedBoolean.Should().BeTrue();
        }

        [TestCase(0,2)]
        [TestCase(1,2)]
        public void CorrectlyReturnFalseForOutOfBoundRequestToGetGridPostitionToTheRightOfArbitraryPosition(int row, int column)
        {
            var expectedBoolean = _game.CheckMoveOnRightIs(row, column, Moves.Blank);
            expectedBoolean.Should().BeFalse();
        }

        [TestCase(2, 1, Moves.X)]
        [TestCase(1, 1, Moves.O)]
        [TestCase(0, 1, Moves.O)]
        public void CorrectlyReturnTrueForRequestToGetGridPostionToTheRightOfArbitraryPosition(int row, int column, Moves expectedMove)
        {
            var expectedBoolean = _game.CheckMoveOnRightIs(row, column, expectedMove);
            expectedBoolean.Should().BeTrue();
        }
    }
}
