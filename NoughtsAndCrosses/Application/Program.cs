using API;

namespace Application
{
    class Program
    {
        static void Main()
        {
            Game game = new Game();
            TurnValidator turnValidator = new TurnValidator();
            WinningGridCalculator winChecker = new WinningGridCalculator();

            //done
            game.Introduction();
            string userInput = game.Turn();
            while (!(winChecker. || game.IsDrawn()))
                game.Turn();

            game.ExitMessage();
        }
    }
}
