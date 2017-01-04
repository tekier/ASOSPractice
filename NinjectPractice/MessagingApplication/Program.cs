using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using NinjectPractice.API;

namespace MessagingApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter message and recipient:");
            string input = Console.ReadLine();
            Console.WriteLine();

            RawMessageParser parser = new RawMessageParser(input);
            while (!parser.IsValidUserInput())
            {
                Console.WriteLine("Please reenter in format - #Content# : #Recipient#");
                input = Console.ReadLine();
                parser = new RawMessageParser(input);
                Console.WriteLine();
            }

            while (!input.Equals("exit"))
            {
                using (IKernel kernel = new StandardKernel(new Bindings()))
                {
                    kernel.Load(Assembly.GetExecutingAssembly());
                    new MessageSender().SendMessage(kernel.Get<ISender>(), parser.GetMessageContent(), parser.GetMessageRecipient());
                    Console.WriteLine();
                    
                }
                Console.WriteLine("Enter message and recipient:");
                input = Console.ReadLine();
                parser = new RawMessageParser(input);
                while (!parser.IsValidUserInput())
                {
                    Console.WriteLine("Please reenter in format - #Content# : #Recipient#");
                    string newInput = Console.ReadLine();
                    parser = new RawMessageParser(newInput);
                    Console.WriteLine();
                }
            }
        }
    }
}


