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
            string input = Console.ReadLine();
            while (!input.Equals("exit"))
            {
                using (IKernel kernel = new StandardKernel(new Bindings()))
                {
                    kernel.Load(Assembly.GetExecutingAssembly());
                    new MessageSender().SendMessage(kernel.Get<ISender>(), input, "ANON"); 
                }
                input = Console.ReadLine();
            }
        }
    }
}
