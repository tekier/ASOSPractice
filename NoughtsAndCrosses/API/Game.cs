namespace API
{
    public class Game
    {
        private Logic _game;
        private int _numberOfTurns;
        public Game()
        {
            _game = new Logic();
            _numberOfTurns = 0;
        }
        public bool IsDrawn()
        {
            return _numberOfTurns == 9;
        }

        public Moves[] GetGameGrid()
        {
            return _game.GetGrid();
        }

        public void Add(Moves move, int position)
        {
            _numberOfTurns++;
            _game.AddToGrid(move, position);
        }
    }
}
