//using System;
//using FluentAssertions;
//using NUnit.Framework;
//using TicTacToe.API;

//namespace TicTacToe.Tests
//{
//    [TestFixture]
//    public class TicTacToeGameInputValidationShould
//    {
//        private TicTacToeGame _game;

//        [SetUp]
//        public void SetUp()
//        {
//            _game = new TicTacToeGame();
//        }

//        [Test]
//        public void BeEmptyOnInitialisation()
//        {
//            var expectedArray = new[]
//            {
//                new[] {Moves.Blank, Moves.Blank, Moves.Blank},
//                new[] {Moves.Blank, Moves.Blank, Moves.Blank},
//                new[] {Moves.Blank, Moves.Blank, Moves.Blank}
//            };
//            var actualArray = _game.GetGameState();
//            var areEqual = HelperJaggedArrayComparer(expectedArray, actualArray);
//            areEqual.Should().BeTrue();
//        }

//        [TestCase("x")]
//        [TestCase("o")]
//        [TestCase("X")]
//        [TestCase("O")]
//        [TestCase("0")]
//        public void ValidateUserInputToBeXorO(string simulatedUserInput)
//        {
//            bool actualReturnedFlag = _game.ValidateUserInput(simulatedUserInput);
//            actualReturnedFlag.Should().BeTrue();
//        }

//        [TestCase("U")]
//        public void ReturnFalseForInvalidUserInput(string simulatedUserInput)
//        {
//            bool actualReturnedFlag = _game.ValidateUserInput(simulatedUserInput);
//            actualReturnedFlag.Should().BeFalse();
//        }

//        [TestCase("X", Moves.X)]
//        [TestCase("o", Moves.O)]
//        public void CorrectlyConvertUserInput(string simualatedInputString, Moves expectedMove)
//        {
//            var actualMoveParsed = _game.ParseInputToMove(simualatedInputString);
//            actualMoveParsed.Should().Be(expectedMove);
//        }

//        [Test]
//        public void CorrectlyModifyGameArrayOnUserInputOnFirstMove()
//        {
//            var expectedArray = new[]
//            {
//                new[] {Moves.X, Moves.Blank, Moves.Blank},
//                new[] {Moves.Blank, Moves.Blank, Moves.Blank},
//                new[] {Moves.Blank, Moves.Blank, Moves.Blank}
//            };
//            _game.ExecutePlayerTurn(Moves.X, new Tuple<int, int>(1, 1));
//            var areEqual = HelperJaggedArrayComparer(_game.GetGameState(), expectedArray);
//            areEqual.Should().BeTrue();
//        }

//        private bool HelperJaggedArrayComparer(Moves[][] first, Moves[][] second)
//        {
//            bool areSame = true;
//            for (int i = 0; i < first.Length; i++)
//            {
//                for (int j = 0; j < second.Length; j++)
//                {
//                    if (first[i][j] != second[i][j])
//                        areSame = false;
//                }
//            }
//            return areSame;
//        }
//    }
//}
