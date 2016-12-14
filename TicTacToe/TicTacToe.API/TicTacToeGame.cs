using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace TicTacToe.API
{
    public class TicTacToeGame
    {
        private Moves[,] gameArray;

        public TicTacToeGame()
        {
            gameArray = new[,]
            {
                {Moves.Blank, Moves.Blank, Moves.Blank},
                {Moves.Blank, Moves.Blank, Moves.Blank},
                {Moves.Blank, Moves.Blank, Moves.Blank}
            };
        }

        public Moves[,] GetGameState()
        {
            return gameArray;
        }

        public bool ValidateUserInput(string userInput)
        {
            if (new[] {"x", "o", "0"}.Contains(userInput, StringComparer.OrdinalIgnoreCase))
                return true;
            return false;
        }
    }
}
