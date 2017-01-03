using System;

namespace NinjectPractice.Contracts
{
    public class Message
    {
        public string Content { get; set; }
        public string Recipient { get; set; }
        public DateTime TimeStamp { get; set; }

        public Message(string content, string recepient)
        {
            this.Content = content;
            this.Recipient = recepient;
            this.TimeStamp = DateTime.Now;
        }
    }
}
