using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapper
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            first = Int32.Parse(Console.ReadLine());
            second = Int32.Parse(Console.ReadLine());

            first = first ^ second;
            second = first ^ second;
            first = first ^ second;

            Console.WriteLine($"first is now {first}");
            Console.WriteLine($"second is now {second}");
            Console.Read();

        }
    }
}
