using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectPractice.API
{
    public class RawMessageParser
    {
        public bool IsValidUserInput(string rawInput)
        {
            return CorrectLength(rawInput) && HasRecipient(rawInput);
        }

        private bool HasRecipient(string rawInput)
        {
            if (!rawInput.Split(':')[1].Equals(string.Empty))
                return true;
            return false;
        }

        public bool CorrectLength(string rawInput)
        {
            if (rawInput.Split(':').Length == 2)
                return true;
            return false;
        }

        public string GetMessageContent(string rawInput)
        {
            return rawInput.Split(':')[0].Trim();
        }
    }
}
