namespace RockPaperScissorsTDD
{
    class GameCalculator
    {
        public bool ValidateUserInput(string gameInputString)
        {
            if (gameInputString.Equals("p") || gameInputString.Equals("r") || gameInputString.Equals("s"))
            {
                return true;
            }
            return false;
        }

        public string PlayGame(string firstMove, string secondMove)
        {
            if (firstMove.Equals(secondMove))
            {
                return "Game Tied";
            }
            if (firstMove.Equals("s") && secondMove.Equals("p") || firstMove.Equals("p") && secondMove.Equals("s"))
            {
                return "Scissors cut through paper";
            }
            if (firstMove.Equals("s") && secondMove.Equals("r") || firstMove.Equals("r") && secondMove.Equals("s"))
            {
                return "Rock crushes scissors";
            }
            return "Paper covers rock";
           
        }
    }
}