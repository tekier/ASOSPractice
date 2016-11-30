using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsTDD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(typeof(string).Assembly.ImageRuntimeVersion);
            GameCalculator game = new GameCalculator();
            Console.WriteLine("Welcome to the game.");
            Console.WriteLine("Enter first players move:");
            string firstInput = Console.ReadLine();
            while (!game.ValidateUserInput(firstInput))
            {
                Console.WriteLine("Please reenter.");
                firstInput = Console.ReadLine();
            }
            Console.WriteLine("Enter second players move");
            string secondInput = Console.ReadLine();
            while (!game.ValidateUserInput(secondInput))
            {
                Console.WriteLine("Please reenter.");
                secondInput = Console.ReadLine();
            }

            Console.WriteLine(game.PlayGame(firstInput, secondInput));

            Console.ReadLine();
        }
    }
}
