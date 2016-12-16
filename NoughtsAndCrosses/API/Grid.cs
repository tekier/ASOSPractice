using System.Net.Configuration;
using System.Runtime.Remoting.Messaging;

namespace API
{
    public class Grid
    {
        private Moves[] _gameGrid;

        internal Grid()
        {
            _gameGrid = new[] {Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank, Moves.Blank};
        }

        public int GetLength()
        {
            return _gameGrid.Length;
        }
        public Moves[] GetGrid()
        {
            return _gameGrid;
        }

        public void AddValueToGrid(Moves move, int position)
        {
            _gameGrid[position] = move;
        }
    }
}
