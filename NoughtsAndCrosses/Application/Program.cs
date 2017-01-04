using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using API;

namespace Application
{
    class Program
    {
        static void Main()
        {
            WelcomeMessage();
            Game.DrawGrid();


            Console.Read();
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the game");
            MakeSpace();
        }

        private static void MakeSpace()
        {
            Console.WriteLine();
        }
    }
}
