using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace API
{
    public class Game
    {
        private Grid _gameGrid = new Grid();
        private static InputValidator _validator = new InputValidator();

        public static void DrawGrid()
        {
            Grid.Print();
        }

        public static int CalculatePosition(int x, int y)
        {
            return x*3 + y;
        }

        public static bool IsValid(string input)
        {
            return _validator.IsValid(input);
        }

        public static bool HasBeenWon()
        {
            return VerticalWin(Grid.GetGrid()) 
                   || HorizantalWin(Grid.GetGrid())
                   || DiagonalWin(Grid.GetGrid());
        }

        private static bool DiagonalWin(Moves[] getGrid)
        {
            bool isNotBlank = getGrid[4] == Moves.Blank;
            bool caseOneWin = isNotBlank && ((getGrid[0] == getGrid[4]) == (getGrid[4] == getGrid[8]));
            bool caseTwoWin = isNotBlank && ((getGrid[2] == getGrid[4]) == (getGrid[4] == getGrid[6]));
            return caseOneWin || caseTwoWin;
        }

        private static bool HorizantalWin(Moves[] getGrid)
        {
            return true;
        }

        private static bool VerticalWin(Moves[] getGrid)
        {
            return true;
        }

        public static Moves Parse(string input)
        {
            var rawMove = input.Split(',')[0].ToLower();
            if(rawMove.Equals("x"))
                return Moves.X;
            return Moves.O;
        }

        public static int GetRow(string input)
        {
            return 0;
        }

        public static int GetColumn(string input)
        {
            return 0;
        }
    }

}
