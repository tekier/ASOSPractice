using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    internal class Turn
    {
        private int _row;
        private int _column;
        private Moves _move;
        private TurnValidator validator;

        public Turn(string inputString)
        {
            validator = new TurnValidator(inputString);
            CreateTurn();
        }

        private void CreateTurn(string input)
        {
            if
        }

        public Moves GetMove()
        {
            return _move;
        }

        public int GetPosition(int length)
        {
            return _column + (_row*length);
        }
    }
}
