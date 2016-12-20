using System;
using API;

namespace Application
{
    class Program
    {
        static void Main()
        {
            Game game = new Game();
            TurnValidator turnValidator = new TurnValidator();
            WinningGridCalculator winChecker = new WinningGridCalculator();
            TurnParser parser = new TurnParser();
            PrettyPrintGrid(game.GetGameGrid());
            while (!winChecker.Win(game.GetGameGrid()) || !game.IsDrawn())
            {
                string userinput = Console.ReadLine();
                if (turnValidator.IsValid(userinput))
                {
                    game.Add(parser.GetMove(userinput), parser.GetPositionOnGrid(userinput));
                    PrettyPrintGrid(game.GetGameGrid());
                }
                else
                {
                    Console.WriteLine("error input - try again");
                }
            }
            Console.WriteLine("finished");
        }

        private static void PrettyPrintGrid(Moves[] gameGrid)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.Write($" [{gameGrid[i]}] ");
                if ((i + 1)%3 == 0)
                    Console.WriteLine();
            }
        }

        private static string GetUserInput(TurnValidator validator)
        {
            string userInput = Console.ReadLine();
            var a = validator.IsValid(userInput);
            //while (!validator.IsValid(userInput))
            {
                Console.WriteLine("Error. Try again: ");
                userInput = Console.ReadLine();
            }
            return userInput;
        }

        static void PrintIntroduction()
        {
            Console.WriteLine("Welcome to the game!!");
            Console.WriteLine();
        }

        static void PrintFriendlyTurnMessage()
        {
            Console.WriteLine("Enter input as [row] [column] [X|O]");
        }

        static void PrintExitMessage()
        {
            Console.WriteLine();
            Console.WriteLine("See you next time!");
            Console.Read();
        }
    }
}
