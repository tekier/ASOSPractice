using System;
using System.Diagnostics.CodeAnalysis;

namespace StringCalculatorTDD
{
    public class StringCalculator
    {
        public static int Calculate(string input)
        {
            /**if (input == "0,1")
                return 1;
            if (input == "1,1")
                return 2;
            if (input == "1,2")
                return 3;**/

            int sum = 0;
            if (input != "")
            {
                foreach (string word in input.Split(','))
                {
                    int parsedInt;
                    if (int.TryParse(word, out parsedInt))
                    {
                        sum += parsedInt;
                    }

                }
            }
            return sum;
        }
    }
}
