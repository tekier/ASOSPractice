using API;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TurnParserShould
    {
        private TurnParser _testParser;

        [SetUp]
        public void SetUp()
        {
            _testParser = new TurnParser();
        }

        [TestCase("0 0 X", 0)]
        [TestCase("0 1 X", 1)]
        [TestCase("0 2 X", 2)]
        [TestCase("1 0 X", 3)]
        [TestCase("1 1 X", 4)]
        [TestCase("1 2 X", 5)]
        [TestCase("2 0 X", 6)]
        [TestCase("2 1 X", 7)]
        [TestCase("2 2 X", 8)]
        public void GetTheCorrectIndexOnOneDimensionalArrayForTwoDimensionalCoordinates(string input, int expectedValue)
        {
            var actualValue = _testParser.GetPositionOnGrid(input);
            actualValue.Should().Be(expectedValue);
        }

        [TestCase("1 1 X", Moves.X)]
        [TestCase("0 0 O", Moves.O)]
        public void ShouldParseCorrectMoveFromString(string input, Moves expectedMove)
        {
            var actualMove = _testParser.GetMove(input);
            actualMove.Should().Be(expectedMove);
        }
    }
}
