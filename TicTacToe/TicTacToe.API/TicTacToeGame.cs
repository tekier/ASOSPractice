using System;
using System.Linq;

namespace TicTacToe.API
{
    public class TicTacToeGame
    {
        private Moves[][] gameArray;

        public TicTacToeGame()
        {
            gameArray = new[]
            {
                new[] {Moves.Blank, Moves.Blank, Moves.Blank},
                new[] {Moves.Blank, Moves.Blank, Moves.Blank},
                new[] {Moves.Blank, Moves.Blank, Moves.Blank}
            };
        }

        public Moves[][] GetGameState()
        {
            return gameArray;
        }

        public bool ValidateUserInput(string userInput)
        {
            if (new[] {"x", "o", "0"}.Contains(userInput, StringComparer.OrdinalIgnoreCase))
                return true;
            return false;
        }

        public void PrintCurrentGameState()
        {
            var oneDimensionalLength = gameArray[0].Length;
            PrintColumnsAndRows(oneDimensionalLength);
        }

        private void PrintColumnsAndRows(int oneDimensionalLength)
        {
            for (int rowIndex = 0; rowIndex < oneDimensionalLength; rowIndex++)
            {
                PrintFormattedRow(oneDimensionalLength, rowIndex);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private void PrintFormattedRow(int oneDimensionalLength, int rowIndex)
        {
            for (int coloumnIndex = 0; coloumnIndex < oneDimensionalLength; coloumnIndex++)
            {
                var elementToWriteOutHere = gameArray[rowIndex][coloumnIndex] == Moves.Blank
                    ? " "
                    : gameArray[rowIndex][coloumnIndex].ToString();
                Console.Write($" [{elementToWriteOutHere}] ");
            }
        }

        public Moves ParseInputToMove(string userMove)
        {
            if(userMove.ToLower().Equals("x"))
                return Moves.X;
            return Moves.O;
        }

        public void ExecutePlayerTurn(Moves move, Tuple<int, int> coordinates)
        {
            int column = coordinates.Item2-1;
            int row = coordinates.Item1-1;
            gameArray[row][column] = move;

        }
    }
}
