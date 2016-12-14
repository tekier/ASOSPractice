using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.API;

namespace TicTacToe.App
{
    sealed class Program
    {
        private static TicTacToeGame _game;
        static void Main(string[] args)
        {
            _game = new TicTacToeGame();
            _game.PrintCurrentGameState();
            Console.Read();
        }
    }
}
