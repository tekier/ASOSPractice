using System;
using Microsoft.WindowsAzure.Storage.Table;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumWebApplication.Contracts
{
    public class AlbumEntity : TableEntity
    {
        public AlbumEntity(string title, string artist)
        {
            this.PartitionKey = artist;
            this.RowKey = title;
        }

        public AlbumEntity() {}

        public virtual string Id { get; set; }
        public virtual DateTime Year { get; set; }

    }
}
