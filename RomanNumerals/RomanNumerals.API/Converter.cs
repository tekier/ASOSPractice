using System;
using System.IO;
using System.Linq;

namespace RomanNumerals.API
{
    public class Converter
    {
        private const string LocationOfMappings = @"C:\Mappings.txt";
        private const string IntTooBigErrorMessage = @"Number too big.";
        private const string NegativeIntegerErrorMessage = @"Numbers less than 1 not supported.";
        public string GetRomanNumeralRepresentationOf(int decimalNumber)
        {
            if (10000 < decimalNumber)
                throw new Exception(IntTooBigErrorMessage);
            if(decimalNumber < 1)
                throw new Exception(NegativeIntegerErrorMessage);

            var line = File.ReadLines(LocationOfMappings).Skip(decimalNumber).Take(1);
            return line.First().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries)[1];
        }
    }
}
