using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumWebApplication.View
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Process.Start(Path.Combine("..", "..", "Albums.html"));
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
