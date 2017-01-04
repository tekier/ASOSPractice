using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using API;
using Contracts;
using Microsoft.Build.Tasks;

namespace Application
{
    class Program
    {
        static void Main()
        {
            WelcomeMessage();
            Game.DrawGrid();

            while (!Game.HasBeenWon())
            {
                string input = Console.ReadLine();
                while (!Game.IsValid(input))
                {
                    ErrorMessage();
                    input = Console.ReadLine();
                }

                Moves currentMove = Game.Parse(input);
                int currentRow = Game.GetRow(input);
                int currentCol = Game.GetColumn(input);
                int currentPosition = Game.CalculatePosition(currentRow, currentCol);
            }
            Console.Read();
        }

        private static void ErrorMessage()
        {
            Console.WriteLine("Please re-enter valid input in form #[X | O], [row & column]#\n");
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the game\n");
        }
    }
}
