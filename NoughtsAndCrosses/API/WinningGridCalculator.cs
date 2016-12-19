using System.Linq;

namespace API
{
    public class WinningGridCalculator
    {
        private Moves[] _currentGameState;

        public bool Win(Moves[] moves)
        {
            _currentGameState = moves;
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
                if (_currentGameState[index] != Moves.Blank && _currentGameState[index] == _currentGameState[index + 3] &&
                    _currentGameState[index + 3] == _currentGameState[index + 6]) return true;
            }
            return false;
        }

        public bool DiagonalWin()
        {
            return _currentGameState[0] != Moves.Blank && _currentGameState[0] == _currentGameState[4] &&
                   _currentGameState[4] == _currentGameState[6];
        }

        public bool ThereIsAnExactSubArrayOf(Moves move)
        {
            Moves[] subArrayToCheck = Enumerable.Repeat(move, 3).ToArray();
            for (int index = 0; index < 7; index += 3)
            {
                if (_currentGameState.Skip(index).Take(3).SequenceEqual(subArrayToCheck)) return true;
            }
            return false;
        }
    }
}
