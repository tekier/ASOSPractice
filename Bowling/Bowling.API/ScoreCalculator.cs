using System;

/*  
             index:       1   2   3   4   5   6   7   8   9   10  11
             frames:     [X   X   X   X   X   X   X   X   X   X   XX]
             framescore: 30  30  30  30  30  30  30  30  30  30  n/a
             cumlative:  30  60  90 120 150 180 210 240 270 300  n/a  
*/

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

            GetTotalScoreForThisFrameConsideringSubsequentFrames(listOfScores, 0, &total);

            return total;
        }

        private unsafe void GetTotalScoreForThisFrameConsideringSubsequentFrames(string[] listOfScores, int currentIndex, int* total)
        {
            if (currentIndex < listOfScores.Length)
            {
                if (listOfScores[currentIndex].Equals("X"))
                {
                    *total += GetTotalScoreForFrameWhenFrameIsStrike(listOfScores, currentIndex);
                    GetTotalScoreForThisFrameConsideringSubsequentFrames(listOfScores, ++currentIndex, total);
                }
                else
                {
                    *total += GetTotalScoreForThisFrame(listOfScores[currentIndex], 0);
                    GetTotalScoreForThisFrameConsideringSubsequentFrames(listOfScores, ++currentIndex, total);
                }
            }
        }

        private int GetTotalScoreForFrameWhenFrameIsStrike(string[] listOfScores, int currentIndex)
        {
            int scoreToReturn = 0;
            for (int i = 0; i < 3; i++)
            {
                if (currentIndex < listOfScores.Length - i)
                {
                    if (!listOfScores[currentIndex + i].Equals("X"))
                    {
                        scoreToReturn += GetTotalScoreForThisFrame(listOfScores[currentIndex + i],i);
                    }
                    else
                    {
                        scoreToReturn += GetTotalScoreForThisFrame(listOfScores[currentIndex + i], i - 1);
                    }        
                    //0, 1, 2
                }
            }
            return scoreToReturn;
        }

        private int GetTotalScoreForThisFrame(string frameScore, int isPartOfPrecedingScore)
        {
            if (frameScore.Equals("X"))
                return 10;
            if (frameScore.Length > 1)
            {
                return GetTotalScoreForComplexFrames(frameScore, isPartOfPrecedingScore);
            }
            return 0;
        }

        private int GetTotalScoreForComplexFrames(string frameScore, int flag)
        {
            if (frameScore.Equals("XX"))
                return 10;

            if (flag == 0)
            {
                int score = 0;
                if (char.IsDigit(frameScore[0]))
                    score += frameScore[0] - '0';
                if (char.IsDigit(frameScore[1]))
                    score += frameScore[1] - '0';
                return score;
            }

            if (flag == 1)
            {
                int score = 0;
                if (char.IsDigit(frameScore[0]))
                    score += frameScore[0] - '0';
                return score;
            }

            if (flag == 2)
            {
                int score = 0;
                if (char.IsDigit(frameScore[1]))
                    score += frameScore[1] - '0';
                return score;
            }
            return 0;
        }
    }
}
