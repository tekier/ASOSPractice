using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using API;

namespace Application
{
    class Program
    {
        static void Main()
        {
            Game game = new Game();

            game.Introduction();

            while (!game.IsWon() || !game.IsDrawn())
                game.Turn();

            game.ExitMessage();
        }
    }
}
