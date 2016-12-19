using System;

namespace API
{
    public class Game
    {
        private Logic _game;
        private int _numberOfTurns;
        public Game()
        {
            _game = new Logic();
            _numberOfTurns = 0;
        }
        #region Conditions to check game as ended.

        public bool IsDrawn()
        {
            return _numberOfTurns == 9;
        }

        #endregion
        public void Introduction()
        {
            Console.WriteLine("Welcome to the game!!");
            Console.WriteLine();
        }
        public void ExitMessage()
        {
            Console.WriteLine();
            Console.WriteLine("See you next time!");
            Console.Read();
        }
        public void UpdateGrid()
        {
            
        }
        private void FriendlyTurnMessage()
        {
            Console.WriteLine("Enter input as [row]\t[column\t[X|O]");
        }

        public string Turn()
        {
            FriendlyTurnMessage();
            string userInput = Console.ReadLine();
            return userInput;
        }    
    }
}
