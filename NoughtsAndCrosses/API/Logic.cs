namespace API
{
    internal class Logic
    {
        private Grid _gameGrid;
        private WinningGridCalculator _calculator;

        public Logic()
        {
            _gameGrid = new Grid();
        }

        public Moves[] GetGrid()
        {
            return _gameGrid.GetGrid();
        }

        public void AddToGrid(Moves move, int position)
        {
            _gameGrid.AddValueToGrid(move, position);
        }
    }
}
