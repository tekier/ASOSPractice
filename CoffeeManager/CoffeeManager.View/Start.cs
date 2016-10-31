using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.View
{
    class Start
    {
        public static void Main(string[] _)
        {
            try
            {
                Process.Start(Path.Combine("..","..","CoffeeView.html"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
                throw;
            }
        }
    }
}
