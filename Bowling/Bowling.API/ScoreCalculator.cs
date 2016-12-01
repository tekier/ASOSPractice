using System;
using System.CodeDom;
using System.Runtime.InteropServices;

namespace Bowling.API
{
    public class ScoreCalculator
    {
        public bool VerifyCorrectNumberOfFrames(string scoreString)
        {
            return scoreString.Split('|').Length == 12;
        }

        public unsafe int CalculateScore(string scoreString)
        {
            string[] listOfScores = scoreString.Split(new[] {"|"}, StringSplitOptions.RemoveEmptyEntries);
            int total = 0;

            GetTotalScoreForThisFrameConsideringSubsequentFrames(listOfScores, 0,  &total);

            return total;
        }

        private unsafe int GetTotalScoreForThisFrameConsideringSubsequentFrames(string[] listOfScores, int currentIndex, int* total)
        {
            if (listOfScores[currentIndex].Equals("X"))
            {
                *total += GetTotalScoreForFrameWhenFrameIsStrike(listOfScores, currentIndex);
                GetTotalScoreForThisFrameConsideringSubsequentFrames(listOfScores, ++currentIndex, total);
            }
            else
            {
                *total += GetTotalScoreForThisFrame(listOfScores[currentIndex], currentIndex, listOfScores.Length);
            }
            return *total;
        }

        private int GetTotalScoreForFrameWhenFrameIsStrike(string[] listOfScores, int currentIndex)
        {
            int scoreToReturn = 0;
            for (int i = 0; i < 3; i++)
            {
                if(currentIndex < listOfScores.Length - i)
                    scoreToReturn += GetTotalScoreForThisFrame(listOfScores[currentIndex + i], currentIndex, listOfScores.Length);
            }
            return scoreToReturn;
        }

        private int GetTotalScoreForThisFrame(string frameScore, int currentIndex, int length)
        {
            if(frameScore.Equals("X"))
                return 10;
            if (frameScore.Equals("XX"))
                return 10;
            return 0;
            /*
            foreach (var score in frameScore)
            {
                if (char.IsDigit(score))
                totalToReturn += score - '0';
            }
            return 0;
            
             index:       1   2   3   4   5   6   7   8   9   10  11
             frames:     [X   X   X   X   X   X   X   X   X   X   XX]
             framescore: 30  30  30  30  30  30  30  30  30  30  n/a
             cumlative:  30  60  90 120 150 180 210 240 270 300  n/a  
             262*/
        }
    }
}
