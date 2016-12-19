using System;
using System.Linq;
using System.Net;

namespace API
{
    public class WinningGridCalculator
    {
        private Moves[] currentGameState;

        public bool Win(Moves[] moves)
        {
            currentGameState = moves;
            return HorizontalWin() || VerticalWin() || DiagonalWin();
        }

        public bool HorizontalWin()
        {
            if (ThereIsAnExactSubArrayOf(Moves.X))
                return true;
            if (ThereIsAnExactSubArrayOf(Moves.O))
                return true;
            return false;
        }

        public bool VerticalWin()
        {
            for (int index = 0; index < 3; index++)
            {
                if (currentGameState[index] == currentGameState[index + 3] &&
                    currentGameState[index + 3] == currentGameState[index + 6]) return true;
            }
            return false;
        }

        public bool DiagonalWin()
        {
        }

        public bool ThereIsAnExactSubArrayOf(Moves move)
        {
            Moves[] subArrayToCheck = Enumerable.Repeat(move, 3).ToArray();
            for (int index = 0; index < 7; index += 3)
            {
                if (currentGameState.Skip(index).Take(3).SequenceEqual(subArrayToCheck)) return true;
            }
            return false;
        }
    }
}
