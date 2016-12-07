using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Domain.Tests
{
    [TestFixture]
    public class AzureStorageTableHelperShould
    {
        private AzureStorageTableHelper _helperObject;
        [SetUp]
        public void SetUp()
        {
            _helperObject = new AzureStorageTableHelper();
        }
        [Test]
        public void GetAllEntriesInCloudTableCorrectlyOnRequest()
        {
            var result = _helperObject.GetAllCharacters();
            int actualResultCount = result.Count;
            int expectedResultCount = 6;
            actualResultCount.Should().Be(expectedResultCount);
        }

        [Test]
        public void EnsureFirstAndLastEntriesInTableAreAsExpected()
        {
            var expectedFirst = "Marge";
            var expectedLast = "Ralph";
            var result = _helperObject.GetAllCharacters();
            var actualFirst = result.First().RowKey;
            var actualLast = result.Last().RowKey;

            actualFirst.Should().Be(expectedFirst);
            actualLast.Should().Be(expectedLast);
        }

        [TestCase("Bart")]
        [TestCase("Ralph")]
        public void RetrieveOnlyOneCharacterWhenSpecificCharacterIsRequested(string searchRowKey)
        {
            var result = _helperObject.GetCharacterWithFirstName(searchRowKey).Count;
            result.Should().Be(1);
        }

        [TestCase("Bart", "Simpson")]
        [TestCase("Ralph", "Wiggum")]
        public void EnsureRequestedCharacterIsRetrieved(string searchRowKey, string expectedResult)
        {
            var actualResult = _helperObject.GetCharacterWithFirstName(searchRowKey).First().PartitionKey;

            actualResult.Should().Be(expectedResult);

        }
    }
}
