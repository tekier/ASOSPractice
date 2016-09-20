using System;

namespace StringCalculatorTDD
{
    public class StringCalculator
    {
        public static int Calculate(string input)
        {
            if (input != "")
                return int.Parse(input);
            return 0;
        }
    }
}
