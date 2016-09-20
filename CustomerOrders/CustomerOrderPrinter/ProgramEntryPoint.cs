using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderPrinter
{
    class ProgramEntryPoint
    {
        public static void Main(string[] args)
        {
            CustomerController runnable = new CustomerController();
            runnable.UpdateView();
            var toStopApplicationFromClosing = Console.ReadLine();
        }
    }
}
