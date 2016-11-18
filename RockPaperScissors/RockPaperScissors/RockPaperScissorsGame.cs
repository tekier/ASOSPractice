using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RockPaperScissorsGame
    {
        public static void Main(string[] _)
        {
            
        }

        public string Play(string arg1, string arg2)
        {
            if ((arg1.Equals("r") || arg1.Equals("p")) && (arg2.Equals("p") && !arg1.Equals(arg2)))
            {
                return "Paper Covers Rock";
            }
            if (arg1.Equals("s") && arg2.Equals("p"))
                return "Scissors Cut Paper";
            return "Rock Smashes Scissors";
        }
    }
}
