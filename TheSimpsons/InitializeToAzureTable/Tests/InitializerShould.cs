using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private TableInitializer _initializer;
        private CloudStorageAccount _storageAccount;
        private static CloudTableClient _tableClient;
        private static CloudTable _table;

        [SetUp]
        public void SetUp()
        {
            _storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=tekier;AccountKey=hxHcT89mFxOmO2XEYOsLYEhwm/gTQL8MbhiRnvKg8gIzY2bgVMCj3WvhtxWPj/uNWagoYVktG4lHWiW4Qs2EXg==");
            _tableClient = _storageAccount.CreateCloudTableClient();
            _table = _tableClient.GetTableReference("simpsons");
            _initializer = new TableInitializer();
           
            _initializer.PopulateTable();
           
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
