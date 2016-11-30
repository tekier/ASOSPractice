using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace RockPaperScissorsTDD
{
    [TestFixture]
    class GameCalculatorShould
    {
        private GameCalculator _calculator;
        [SetUp]
        public void SetUp()
        {
            _calculator = new GameCalculator();   
        }

        [TestCase("p")]
        [TestCase("r")]
        [TestCase("s")]
        public void OnlyReturnTrueOnValidInputs(string inputString)
        {
            var isValidInput = _calculator.ValidateUserInput(inputString);
            isValidInput.Should().BeTrue();
        }
        [TestCase("")]
        [TestCase("lkasjdflasjdflkasjdf")]
        [TestCase("t")]
        public void ReturnFalseOnInvalidInputStrings(string inputString)
        {
            var isInvalidInput = _calculator.ValidateUserInput(inputString);
            isInvalidInput.Should().BeFalse();
        }
        
        [Test]
        public void ReturnPaperCoversRockWhenInputIsPAndR()
        {
            var returnString = _calculator.PlayGame("p","r");
            returnString.Should().Be("Paper covers rock");
        }

        [Test]
        public void ReturnScissorsCutThroughPaperWhenInputIsSandP()
        {
            var returnString = _calculator.PlayGame("s", "p");
            returnString.Should().Be("Scissors cut through paper");
        }

        [Test]
        public void ReturnRockCrushesScissorsWhenInputIsRandS()
        {
            var returnString = _calculator.PlayGame("s", "r");
            returnString.Should().Be("Rock crushes scissors");
        }

        [TestCase("r","r")]
        [TestCase("s","s")]
        [TestCase("p","p")]
        public void ReturnDrawWhenBothUserInputsAreSame(string firstInput, string secondInput)
        {
            var returnString = _calculator.PlayGame(firstInput, secondInput);
            returnString.Should().Be("Game Tied");
        }


    }
}
