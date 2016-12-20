using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                Console.WriteLine(IsPowerOfTwo(n));
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();
        }

        static bool IsPowerOfTwo(int n)
        {
            if (n % 2 == 1)
                return false;
            if (n == 2)
                return true;
            return IsPowerOfTwo(n/2);
        }
    }
}
