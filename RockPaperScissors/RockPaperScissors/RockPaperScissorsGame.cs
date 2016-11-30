using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RockPaperScissorsGame
    {
        private string arg1;
        private string arg2;
        public static void Main(string[] _)
        {
            
        }

        public string Play()
        {
            if ((arg1.Equals("r") && arg2.Equals("p")) || (arg1.Equals("p") && arg2.Equals("r")))
            {
                return "Paper Covers Rock";
            }
            if ((arg1.Equals("s") && arg2.Equals("p")) || (arg1.Equals("p") && arg2.Equals("s")))
                return "Scissors Cut Paper";

            if ((arg1.Equals("r") && arg2.Equals("s")) || (arg1.Equals("s") && arg2.Equals("r")))
            {
                return "Rock Smashes Scissors";
            }
            return "";
        }

        public bool CheckIfInputsAreValid(string userInput)
        {
            string[] validInputs = {"r", "p", "s"};
            if (userInput.Equals(validInputs))
            {
                return true;
            }
            return false;
        }
    }
}