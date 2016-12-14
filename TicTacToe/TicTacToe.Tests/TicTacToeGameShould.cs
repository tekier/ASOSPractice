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
            Moves[,] expectedArray =
            {
                {Moves.Blank, Moves.Blank, Moves.Blank},
                {Moves.Blank, Moves.Blank, Moves.Blank},
                {Moves.Blank, Moves.Blank, Moves.Blank}
            };
            var actualArray = _game.GetGameState();
            actualArray.Should().Equal(expectedArray);
        }

        [TestCase("x")]
        [TestCase("o")]
        public void ValidateUserInputToBeXorO(string simulatedUserInput)
        {
            bool actualReturnedFlag = _game.ValidateUserInput(simulatedUserInput);
        }
    }
}
