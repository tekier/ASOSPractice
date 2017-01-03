using System;
using NinjectPractice.Contracts;

namespace NinjectPractice.API
{
    public class Whatsapp : ISender
    {
        public void Send(Message messageToSend)
        {
            Console.WriteLine("Whatsapp message \"{0}\" sent to {1} at {2}", messageToSend.Content, messageToSend.Recipient,
                messageToSend.TimeStamp);
        }
    }
}
