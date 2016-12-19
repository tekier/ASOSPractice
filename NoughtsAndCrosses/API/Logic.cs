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

        public void AddVa

        public bool HasWon()
        {
            _calculator = new WinningGridCalculator();
            return _calculator.HorizontalWin(_gameGrid.GetGrid());
    }
}
