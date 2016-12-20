using System;
using FluentAssertions;
using NUnit.Framework;
using TicTacToe.API;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class GameInputValidationShould
    {
        private UserInputValidator _game;

        [SetUp]
        public void SetUp()
        {
            _game = new UserInputValidator();
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

        [TestCase("X", Moves.X)]
        [TestCase("o", Moves.O)]
        public void CorrectlyConvertUserInput(string simualatedInputString, Moves expectedMove)
        {
            var actualMoveParsed = _game.ParseInputToMove(simualatedInputString);
            actualMoveParsed.Should().Be(expectedMove);
        }
    }
}
