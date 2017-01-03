using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace NinjectPractice.Contracts
{
    public class Message
    {
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

        public Message()
        {
            this.Content = "Message not yet initialised.";
            this.TimeStamp = DateTime.Now;
        }
    }
}
