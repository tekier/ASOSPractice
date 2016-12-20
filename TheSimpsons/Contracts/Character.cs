using Microsoft.WindowsAzure.Storage.Table;

namespace Contracts
{
    public sealed class Character : TableEntity
    {
        public Character(string  forename, string surname, int age, string specialItem)
        {
            PartitionKey = surname;
            RowKey = forename;
            Age = age;
            SpecialItem = specialItem;
        }

        public Character()
        {
            
        }

        public int Age { get; set; }
        public string SpecialItem { get; set; }
    }
}
