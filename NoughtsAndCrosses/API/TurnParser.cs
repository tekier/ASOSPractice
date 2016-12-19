using System.Linq;

namespace API
{
    public class TurnParser
    {
        public int GetPositionOnGrid(string userInput)
        {
            int row = int.Parse(userInput[0].ToString());
            int column = int.Parse(userInput[2].ToString());
            return column + (row*3);
        }

        public Moves GetMove(string userInput)
        {
            if(userInput.Last() == 'X')
                return Moves.X;
            return Moves.O;
        }
    }
}
