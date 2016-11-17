using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreCalculator
{
    public class BowlingScoreCalc
    {
        public int CalculateScore(string input)
        {
            var listOfDelimiters = new[] {"|", "||"};
            var arrayOfScores = input.Split(listOfDelimiters, StringSplitOptions.RemoveEmptyEntries);
            int gameTotal = 0;
            foreach (string score in arrayOfScores)
            {
                gameTotal += CalculateScoreForIndividualTurn(score);
            }
            return gameTotal;
        }

        private int CalculateScoreForIndividualTurn(string arrayOfScore)
        {
            int total = 0;
            foreach (char character in arrayOfScore)
            {
                int parsed;
                Int32.TryParse(character.ToString(), out parsed);
                if (!parsed.Equals(null))
                {
                    total += parsed;
                }
            }
            return total;
        }
    }
}
