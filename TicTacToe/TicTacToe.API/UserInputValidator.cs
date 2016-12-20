using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.API
{
    public class UserInputValidator
    {
        public bool ValidateUserInput(string userInput)
        {
            if (new[] { "x", "o", "0" }.Contains(userInput, StringComparer.OrdinalIgnoreCase))
                return true;
            return false;
        }

        public Moves ParseInputToMove(string userMove)
        {
            if (userMove.ToLower().Equals("x"))
                return Moves.X;
            return Moves.O;
        }
    }
}
