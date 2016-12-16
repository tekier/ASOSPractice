using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable SuspiciousTypeConversion.Global

namespace API
{
    internal class TurnValidator
    {
        public bool IsValid(string userInput)
        {
            string santizedString = RemoveWhiteSpaces(userInput);
            return CorrectLength(santizedString) && FirstTwoCharactersAreIntsInRange(santizedString) && ThirdCharacterIsValidMove(santizedString);
        }

        private bool ThirdCharacterIsValidMove(string userInput)
        {
            if (userInput[2].Equals("X"))
                return true;
            if (userInput[2].Equals("O"))
                return true;
            return false;
        }

        private bool FirstTwoCharactersAreIntsInRange(string userInput)
        {
            bool firstCharIsDigit = char.IsDigit(userInput[0]);
            bool secondCharIsDigit = char.IsDigit(userInput[1]);

            return firstCharIsDigit && secondCharIsDigit;
        }

        private string RemoveWhiteSpaces(string userInput)
        {
            return userInput.Replace(" ", string.Empty);
        }

        private bool CorrectLength(string userInput)
        {
            return userInput.Length == 3;
        }
    }
}
