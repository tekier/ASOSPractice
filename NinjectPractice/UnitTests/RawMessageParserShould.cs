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

        [SetUp]
        public void SetUp()
        {
            _testParser = new RawMessageParser();
        }

        [TestCase("yadayadayada : Tawqir")]
        [TestCase("yad a ya  da  y  ada :      Tawqir")]
        [TestCase(":1234")]
        [TestCase("hello there : Barbara")]
        [TestCase(":XXXX")]
        public void CorrectlyIdentifyValidInputs(string rawInput)
        {
            bool expectedTrue = _testParser.IsValidUserInput(rawInput);
            expectedTrue.Should().BeTrue();
        }

        [TestCase("random strign")]
        [TestCase("message to no one :")]
        public void CorrectlyIdentifyInvalidInputs(string rawInput)
        {
            bool expectedFalse = _testParser.IsValidUserInput(rawInput);
            expectedFalse.Should().BeFalse();
        }

        [TestCase("hello there : Barbara", "hello there")]
        [TestCase(":", "")]
        public void CorrectlyExtractMessageContentFromRawUserInput(string rawInput, string expectedContent)
        {
            var actualExtractedContent = _testParser.GetMessageContent(rawInput);
            actualExtractedContent.Should().Be(expectedContent);
        }
    }
}
