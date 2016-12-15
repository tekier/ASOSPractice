//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using FluentAssertions;
//using NUnit.Framework;
//using TicTacToe.API;

//namespace TicTacToe.Tests
//{
//    [TestFixture]
//    public class TicTacToeGameLogicShould
//    {
//        private TicTacToeGame _game;

//        [SetUp]
//        public void SetUp(int row, int column)
//        {
//            _game = new TicTacToeGame();
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

//        private Moves[][] JaggedArrayConstructor()
//        {
//            return new Moves[1][];
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
