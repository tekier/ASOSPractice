using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using FluentAssertions;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using NUnit.Framework;

namespace InitializeToAzureTable.Tests
{
    [TestFixture]
    public class InitializerShould
    {
        //private TableInitializer _initializer;
        private CloudStorageAccount _storageAccount;
        private static CloudTableClient _tableClient;
        private static CloudTable _table;

        [SetUp]
        public async Task SetUp()
        {
            _storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=tekier;AccountKey=hxHcT89mFxOmO2XEYOsLYEhwm/gTQL8MbhiRnvKg8gIzY2bgVMCj3WvhtxWPj/uNWagoYVktG4lHWiW4Qs2EXg==");
            _tableClient = _storageAccount.CreateCloudTableClient();
            _table = _tableClient.GetTableReference("simpsons");

            await _table.CreateIfNotExistsAsync();

            List<Character> listOfCharacters = new List<Character>
            {
                new Character("Bart", "Simpson", 10, "skateboard"),
                new Character("Marge", "Bouvier", 36, "spatula"),
                new Character("Ralph", "Wiggum", 11, "hair"),
                new Character("Hans", "Moleman", 50, "cane"),
                new Character("Maggie", "Simpson", 1, "pacifier"),
                new Character("Moe", "Szyslak", 46, "shotgun")
            };

            foreach (var character in listOfCharacters)
            {
                var insertionOperation = TableOperation.InsertOrReplace(character);
                _table.Execute(insertionOperation);
            }

            //_initializer = new TableInitializer();

           // _initializer.PopulateTable();
           
        }


        [TearDown]
        public void TearDown()
        {
            //_table.Delete();
        }

        [Test]
        public void ConfirmObjectsAreInTheAzureTable()
        {
            int expectedNumberOfEntries = 6;
            int actualNumberOfEntries = _table.ExecuteQuery(new TableQuery<Character>()).ToList().Count;
            actualNumberOfEntries.Should().Be(expectedNumberOfEntries);
        }

        [Test]
        public void ConfirmObjectsInTheAzureTableAreAssignableToCharacterObjects()
        {
            var charactersFromTheCloud = _table.ExecuteQuery(new TableQuery<Character>()).ToList();
            charactersFromTheCloud.Should().ContainItemsAssignableTo<Character>();

        }
    }

}
