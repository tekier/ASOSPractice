using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

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

        public bool IsWon()
        {
            return _game.HasWon();
        }

        #endregion

        public void Introduction()
        {
            Console.WriteLine("Welcome to the game!!");
            Console.WriteLine();
        }
        public void ExitMessage()
        {
            throw new NotImplementedException();
        }

        public void UpdateGrid()
        {
            
        }

        public void Turn()
        {
            Console.WriteLine("Enter input as /row /coloumn /X/O");
            string userInput = Console.ReadLine();
            if()
        }


        
    }
}
