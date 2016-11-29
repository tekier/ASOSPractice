using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Int32;

namespace BowlingGame.Calculator
{
    public class ScoreCalculator
    {
        public int CalculateScore(string scoreString)
        {
            var individualScores = scoreString.Split(',');
            int[] individualIntScores = ConvertToIntegers(individualScores);
            int totalScore = 0;
            int length = individualIntScores.Length;
            for (int scoreIndex = 0; scoreIndex < length; scoreIndex++)
            {
                if (individualIntScores[scoreIndex] == 10 && scoreIndex < length - 2)
                {
                    totalScore += individualIntScores[scoreIndex];
                    totalScore += individualIntScores[scoreIndex+1];
                    totalScore += individualIntScores[scoreIndex+2];
                }
            }
            /*
            if (scoreString.Equals("10,10,10,10,10,10,10,10,10,10,10,10"))
                return 300;
            if (scoreString.Equals("9,0,9,0,9,0,9,0,9,0,9,0,9,0,9,0,9,0,9,0"))
                return 90;
                */
            return totalScore;
        }

        private int[] ConvertToIntegers(string[] individualScores)
        {
            int[] intArrayToReturn = null;
            try
            {
                intArrayToReturn = Array.ConvertAll(individualScores, int.Parse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return intArrayToReturn;
        }
    }
}
