using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class Grid
    {
        private static Moves[] _oneDimensionalGrid = new Moves[9];

        public static Moves[] GetGrid()
        {
            return _oneDimensionalGrid;
        }

        public static void Print()
        {
            for (int position = 0; position < 9; position++)
            {
                Console.Write((position+1)%3 == 0 ? $"[{_oneDimensionalGrid[position]}]\n" : $"[{_oneDimensionalGrid[position]}] ");
            }
        }
    }
}
