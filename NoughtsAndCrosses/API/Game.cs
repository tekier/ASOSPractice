using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace API
{
    public class Game
    {
        private Grid _gameGrid = new Grid();

        public static void DrawGrid()
        {
            Grid.Print();
        }

        public int CalculatePosition(int x, int y)
        {
            return x*3 + y;
        }

        
    }
}
