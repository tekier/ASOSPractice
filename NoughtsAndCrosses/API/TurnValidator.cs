// ReSharper disable SuspiciousTypeConversion.Global

namespace API
{
    public class TurnValidator
    {
        public bool IsValid(string userInput)
        {
            string santizedString = RemoveWhiteSpaces(userInput);
            return CorrectLength(santizedString) && FirstTwoCharactersAreInts(santizedString) && InputCoordinatesAreInRange(santizedString) && ThirdCharacterIsValidMove(santizedString);
        }

        public bool InputCoordinatesAreInRange(string userInput)
        {
            int firstCoordinate = userInput[0] - '0';
            int secondCoordinate = userInput[1] - '0';
            return (firstCoordinate < 3) && (secondCoordinate < 3);
        }

        public bool ThirdCharacterIsValidMove(string userInput)
        {
            var a = userInput[2];
            if (userInput[2].Equals('X'))
                return true;
            if (userInput[2].Equals('O'))
                return true;
            return false;
        }

        public bool FirstTwoCharactersAreInts(string userInput)
        {
            bool firstCharIsDigit = char.IsDigit(userInput[0]);
            bool secondCharIsDigit = char.IsDigit(userInput[1]);

            return firstCharIsDigit && secondCharIsDigit;
        }

        public string RemoveWhiteSpaces(string userInput)
        {
            return userInput.Replace(" ", string.Empty);
        }

        public bool CorrectLength(string userInput)
        {
            return userInput.Length == 3;
        }
    }
}
