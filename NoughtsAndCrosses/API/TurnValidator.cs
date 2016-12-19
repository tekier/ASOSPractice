// ReSharper disable SuspiciousTypeConversion.Global

using System;

namespace API
{
    public class TurnValidator
    {
        public bool IsValid(string userInput)
        {
            string santizedString = RemoveWhiteSpaces(userInput);
            return CorrectLength(santizedString) && FirstTwoCharactersAreIntsInRange(santizedString) && InputCoordinatesAreInRange(userInput) && ThirdCharacterIsValidMove(santizedString);
        }

        private bool InputCoordinatesAreInRange(string userInput)
        {
            int firstCoordinate = int.Parse(userInput[0].ToString());
            int secondCoordinate = int.Parse(userInput[1].ToString());
            return (firstCoordinate < 3) && (secondCoordinate < 3);
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
