using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using NinjectPractice.Contracts;

namespace NinjectPractice.API
{
    public class MessageSender
    {
        public void SendMessage(string content, string recipient)
        {
            var newMessage = new Message(content, recipient);
            ISender client = new Email();
            client.Send(newMessage);
        }
    }
}
