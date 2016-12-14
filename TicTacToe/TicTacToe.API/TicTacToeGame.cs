namespace TicTacToe.API
{
    public class TicTacToeGame
    {
        private Moves[,] gameArray;

        public TicTacToeGame()
        {
            gameArray = new[,]
            {
                {Moves.Blank, Moves.Blank, Moves.Blank},
                {Moves.Blank, Moves.Blank, Moves.Blank},
                {Moves.Blank, Moves.Blank, Moves.Blank}
            };
        }

        public Moves[,] GetGameState()
        {
            return gameArray;
        }

        public bool ValidateUserInput(string userInput)
        {
            if (userInput.ToLower().Equals(new[] {"x","o","0"}))
                return true;
            return false;
        }
    }
}
