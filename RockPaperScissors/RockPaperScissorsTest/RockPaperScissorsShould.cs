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

        [Test]
        public void ReturnPaperCoversRockWhenUserInputsRAndP()
        {
            string result = game.Play("r","p");
            result.Should().Be("Paper Covers Rock");

        }

        [Test]
        public void ReturnRockSmashesScissorsWhenUserInputsRandS()
        {
            //string result = game.Play("r", "s");
            string result = game.Play("s", "r");
            result.Should().Be("Rock Smashes Scissors");
        }

        [Test]
        public void ReturnScissorsCutPaperWhenUserInputsSandP()
        {
            string result = game.Play("s", "p");
            result.Should().Be("Scissors Cut Paper");
        }

    }
}
