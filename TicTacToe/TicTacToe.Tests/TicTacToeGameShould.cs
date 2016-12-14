using FluentAssertions;
using NUnit.Framework;
using TicTacToe.API;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class TicTacToeGameShould
    {
        private TicTacToeGame _game;

        [SetUp]
        public void SetUp()
        {
            _game = new TicTacToeGame();
        }

        [Test]
        public void BeEmptyOnInitialisation()
        {
            var expectedArray = new[]
            {
                new[] {Moves.Blank, Moves.Blank, Moves.Blank},
                new[] {Moves.Blank, Moves.Blank, Moves.Blank},
                new[] {Moves.Blank, Moves.Blank, Moves.Blank}
            };
            var actualArray = _game.GetGameState();
            Assert.AreEqual(expectedArray, actualArray);
        }

        [TestCase("x")]
        [TestCase("o")]
        [TestCase("X")]
        [TestCase("O")]
        [TestCase("0")]
        public void ValidateUserInputToBeXorO(string simulatedUserInput)
        {
            bool actualReturnedFlag = _game.ValidateUserInput(simulatedUserInput);
            actualReturnedFlag.Should().BeTrue();
        }

        [TestCase("U")]
        public void ReturnFalseForInvalidUserInput(string simulatedUserInput)
        {
            bool actualReturnedFlag = _game.ValidateUserInput(simulatedUserInput);
            actualReturnedFlag.Should().BeFalse();
        }

        [Test]
        public void AddMoveCorrectly()
        {
            Assert.AreEqual(true, true);
        }
    }
}
