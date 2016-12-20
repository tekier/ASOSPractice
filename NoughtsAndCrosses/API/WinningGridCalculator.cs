using System.Linq;

namespace API
{
    public class WinningGridCalculator
    {

        public bool Win(Moves[] moves)
        {
            return HorizontalWin(moves) || VerticalWin(moves) || DiagonalWin(moves);
        }

        public bool HorizontalWin(Moves[] moves)
        {
            if (ThereIsAnExactSubArrayOf(Moves.X, moves))
                return true;
            if (ThereIsAnExactSubArrayOf(Moves.O, moves))
                return true;
            return false;
        }

        public bool VerticalWin(Moves[] moves)
        {
            for (int index = 0; index < 3; index++)
            {
                if (moves[index] != Moves.Blank && moves[index] == moves[index + 3] &&
                    moves[index + 3] == moves[index + 6]) return true;
            }
            return false;
        }

        public bool DiagonalWin(Moves[] moves)
        {
            return moves[0] != Moves.Blank && moves[0] == moves[4] &&
                   moves[4] == moves[6];
        }

        public bool ThereIsAnExactSubArrayOf(Moves move, Moves[] currentGameState)
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
