using System;
using System.Diagnostics;
using System.IO;

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
                Console.WriteLine(Directory.GetCurrentDirectory());
                throw;
            }
        }
    }
}
