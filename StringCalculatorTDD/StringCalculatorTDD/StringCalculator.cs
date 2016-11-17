using System;
using System.Linq;

namespace StringCalculatorTDD

{
    public class StringCalculator
    {
        public int Calculate(string input)
        {
        
            int sum = 0;
            if (input != string.Empty)
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
