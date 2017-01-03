using System;
using NinjectPractice.Contracts;

namespace NinjectPractice.API
{
    public class TextMessage : ISender
    {
        public void Send(Message messageToSend)
        {
            Console.WriteLine("Text message \"{0}\" sent to {1} at {2}", messageToSend.Content, messageToSend.Recipient,
                messageToSend.TimeStamp);
        }
    }
}
