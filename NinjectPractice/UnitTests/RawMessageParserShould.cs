using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NinjectPractice.API;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class RawMessageParserShould
    {
        private RawMessageParser _testParser;

        public void SetUp(string rawInput)
        {
            _testParser = new RawMessageParser(rawInput);
        }

        [TestCase("yadayadayada : Tawqir")]
        [TestCase("yad a ya  da  y  ada :      Tawqir")]
        [TestCase(":1234")]
        [TestCase("hello there : Barbara")]
        [TestCase(":XXXX")]
        public void CorrectlyIdentifyValidInputs(string rawInput)
        {
            SetUp(rawInput);
            bool expectedTrue = _testParser.IsValidUserInput();
            expectedTrue.Should().BeTrue();
        }

        [TestCase("random strign")]
        [TestCase("message to no one :")]
        public void CorrectlyIdentifyInvalidInputs(string rawInput)
        {
            SetUp(rawInput);
            bool expectedFalse = _testParser.IsValidUserInput();
            expectedFalse.Should().BeFalse();
        }

        [TestCase("hello there : Barbara", "hello there")]
        [TestCase(":", "")]
        [TestCase("lol : S", "lol")]
        public void CorrectlyExtractMessageContentFromRawUserInput(string rawInput, string expectedContent)
        {
            SetUp(rawInput);
            var actualExtractedContent = _testParser.GetMessageContent();
            actualExtractedContent.Should().Be(expectedContent);
        }

        [TestCase("hello there : Barbara", "BARBARA")]
        [TestCase(":", "")]
        [TestCase("lol :     S            ", "S")]
        [TestCase("lol :John James Jones", "JOHN JAMES JONES")]
        public void CorrectlyExtractMessageRecipientFromRawUserInput(string rawInput, string expectedRecipient)
        {
            SetUp(rawInput);
            var actualExtractedRecipient = _testParser.GetMessageRecipient();
            actualExtractedRecipient.Should().Be(expectedRecipient);
        }

    }
}
