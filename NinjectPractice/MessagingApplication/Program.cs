using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjectPractice.API;

namespace MessagingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (!input.Equals("exit"))
            {
                var randomNum = new Random().Next();
                if(randomNum%3 == 0)
                    new MessageSender().SendMessage(new Email(), input, "Gary");
                if(randomNum%3 == 1)
                    new MessageSender().SendMessage(new TextMessage(), input, "Angela");
                if(randomNum%3 == 2)
                    new MessageSender().SendMessage(new Whatsapp(), input, "Barbara");

                input = Console.ReadLine();
            }
        }
    }
}
