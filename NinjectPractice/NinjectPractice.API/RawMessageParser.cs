using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NinjectPractice.API
{
    public class RawMessageParser : IDisposable
    {
        private bool _isDisposed;
        private string _rawInput;

        public RawMessageParser(string rawInput)
        {
            this._rawInput = rawInput;
            _isDisposed = false;
        }
        public bool IsValidUserInput()
        {
            return CorrectLength() && HasRecipient();
        }

        private bool HasRecipient()
        {
            if (!_rawInput.Split(':')[1].Equals(string.Empty))
                return true;
            return false;
        }

        public bool CorrectLength()
        {
            if (_rawInput.Split(':').Length == 2)
                return true;
            return false;
        }

        public string GetMessageContent()
        {
            return _rawInput.Split(':')[0].Trim();
        }

        public string GetMessageRecipient()
        {
            return _rawInput.Split(':')[1].Trim().ToUpper();
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool timeToDispose)
        {
            if(!_isDisposed)
                if (timeToDispose)
                    this._rawInput = null;
                    GC.Collect();
            _isDisposed = true;
        }
    }
}
