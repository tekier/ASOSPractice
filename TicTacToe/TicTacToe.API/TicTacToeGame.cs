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
            var oneDimensionalLength= gameArray[0].Length;
            for (int rowIndex = 0; rowIndex < oneDimensionalLength; rowIndex++)
            {
                for (int coloumnIndex = 0; coloumnIndex < oneDimensionalLength; coloumnIndex++)
                {
                    Console.Write($" [{gameArray[rowIndex][coloumnIndex]}] ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
