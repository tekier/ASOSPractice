using API;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TurnValidatorShould
    {
        private TurnValidator _testValidator;

        [SetUp]
        public void SetUp()
        {
            _testValidator = new TurnValidator();
        }

        [TestCase("0 0 X", "00X")]
        [TestCase("2 2 O", "22O")]
        [TestCase("0 1 X", "01X")]
        public void ReturnStringWithNoWhitespaceWhenSanitized(string input, string expectedOutput)
        {
            string actualOutput = _testValidator.RemoveWhiteSpaces(input);
            actualOutput.Should().Be(expectedOutput);
        }

        [TestCase("00X", true)]
        [TestCase("01O", true)]
        [TestCase("22R", false)]
        public void CheckThirdCharacterIsValidMove(string input, bool expectedBool)
        {
            bool actualBool = _testValidator.ThirdCharacterIsValidMove(input);
            actualBool.Should().Be(expectedBool);
        }

        [TestCase("a0X", false)]
        [TestCase("00X", true)]
        [TestCase("01O", true)]
        [TestCase("3bX", false)]
        [TestCase("-9X", false)]
        [TestCase("11X", true)]
        public void CheckFirstTwoCharactersAreIntsInRange(string input, bool expectedBool)
        {
            var actualBool = _testValidator.FirstTwoCharactersAreInts(input);
            actualBool.Should().Be(expectedBool);
        }

        [TestCase("40X", false)]
        [TestCase("11X", true)]
        [TestCase("01O", true)]
        [TestCase("31X", false)]
        [TestCase("22O", true)]
        public void CheckInputCoordinatesAreInRange(string input, bool expectedBool)
        {
            var actualBool = _testValidator.InputCoordinatesAreInRange(input);
            actualBool.Should().Be(expectedBool);
        }

        [TestCase("1 1 X", true)]
        [TestCase("1 0 X", true)]
        [TestCase("0 1 X", true)]
        [TestCase("0 0 X", true)]
        [TestCase("1 1 O", true)]
        [TestCase("1 0 O", true)]
        [TestCase("0 1 O", true)]
        [TestCase("0 0 O", true)]
        [TestCase("1 3 X", false)]
        [TestCase("3 0 0", false)]
        [TestCase("5 5 X", false)]
        [TestCase("1 0 e", false)]
        [TestCase("0 0 E", false)]
        public void CheckUserInputIsValid(string input, bool expectedBool)
        {
            var actualBool = _testValidator.IsValid(input);
            actualBool.Should().Be(expectedBool);

        }
    }
}
