using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using RockPaperScissors;

namespace RockPaperScissorsTest
{
    [TestFixture]
    public class RockPaperScissorsShould
    {
        private RockPaperScissorsGame game;

        [SetUp]
        public void SetUp()
        {
            game = new RockPaperScissorsGame();
        }

        [TestCase("r","p")]
        [TestCase("p","r")]
        public void ReturnPaperCoversRockWhenUserInputsRAndP(string param1, string param2)
        {
            string result = game.Play(param1, param2);
            result.Should().Be("Paper Covers Rock");

        }

        [TestCase("r","s")]
        [TestCase("s","r")]
        public void ReturnRockSmashesScissorsWhenUserInputsRandS(string param1, string param2)
        { 
            string result = game.Play(param1, param2);
            result.Should().Be("Rock Smashes Scissors");
        }

        [TestCase("s", "p")]
        [TestCase("p", "s")]
        public void ReturnScissorsCutPaperWhenUserInputsSandP(string param1, string param2)
        {
            string result = game.Play(param1, param2);
            result.Should().Be("Scissors Cut Paper");
        }

        [TestCase("t", "asdfkjasdk")]
        public void ReturnErrorMessageWhenInvalidInput(string param1, string param2)
        {
            string result = game.Play(param1, param2);
        }
    }
}
