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
        private static GameLogic _game;
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid(3);
            Moves[][] newgrid = new[]
            {
                new[] {Moves.Blank, Moves.Blank, Moves.O},
                new[] {Moves.X, Moves.X, Moves.O},
                new[] {Moves.Blank, Moves.Blank, Moves.X}
            };
            grid.SetGrid(newgrid);

            newgrid = grid.ReturnGrid();
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write($"[{newgrid[row][column]}]\t");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
