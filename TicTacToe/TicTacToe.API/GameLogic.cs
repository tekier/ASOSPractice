using System;
using System.Linq;

namespace TicTacToe.API
{
    public class GameLogic
    {
        private GameGrid _gameArray;

        public GameLogic()
        {
            _gameArray = new GameGrid(3);
        }

        public Moves[][] GetGameState()
        {
            return _gameArray.ReturnGrid();
        }

        //testing only
        public void SetGrid(Moves[][] mm)
        {
            this._gameArray.SetGrid(mm);
        }

        public Moves GetElementAt(int row, int column)
        {
            return _gameArray.GetElementAt(row, column);
        }

        public bool CheckMoveUnderneathIs(int row, int column, Moves moveToCheckAgainst)
        {
            if (row < 2)
                return moveToCheckAgainst == _gameArray.GetElementAt(row+1, column);
            return false;
        }

        public bool CheckMoveAboveIs(int row, int column, Moves moveToCheckAgainst)
        {
            if (row > 0)
                return moveToCheckAgainst == _gameArray.GetElementAt(row-1, column);
            return false;
        }

        public bool CheckMoveOnLeftIs(int row, int column, Moves moveToCheckAgainst)
        {
            if (column > 0)
                return moveToCheckAgainst == _gameArray.GetElementAt(row, column - 1);
            return false;
        }

        public bool CheckMoveOnRightIs(int row, int column, Moves moveToCheckAgainst)
        {
            if (column < 2)
                return moveToCheckAgainst == _gameArray.GetElementAt(row, column+1);
            return false;
        }
    }
}
