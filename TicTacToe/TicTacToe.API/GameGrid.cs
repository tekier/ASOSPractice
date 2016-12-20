using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.API
{
    public class GameGrid
    {
        private Moves[][] _gameArray;
        private static int _squareSize;

        private delegate void NewMoveAssignmentDelegate(ref Moves newMove);

        public Moves[][] ReturnGrid()
        {
            return _gameArray;
        }
        public GameGrid(int numberOfRowsAndColumns)
        {
            _squareSize = numberOfRowsAndColumns;
            _gameArray = new Moves[numberOfRowsAndColumns][];
            IterateOverGameGrid(GetBlank);
        }

        //delete later
        public void SetGrid(Moves[][] mm)
        {
            this._gameArray = mm;
        }

        public Moves GetElementAt(int row, int column)
        {
            return _gameArray[row][column];
        }

        // ReSharper disable once RedundantAssignment
        private void GetBlank(ref Moves newMove)
        {
            newMove = Moves.Blank;
        }

        private void IterateOverGameGrid(NewMoveAssignmentDelegate takeTheRowAndApply)
        {
            for (int rowNumber = 0; rowNumber < _squareSize; rowNumber++)
            {
                IterateOverIndividualRow(rowNumber, takeTheRowAndApply);
            }
        }

        private void IterateOverIndividualRow(int rowNumber, NewMoveAssignmentDelegate takeTheRowAndApply)
        {
            _gameArray[rowNumber] = new Moves[_squareSize];
            for (int columnIndex = 0; columnIndex < _squareSize; columnIndex++)
            {
                takeTheRowAndApply.Invoke(ref _gameArray[rowNumber][columnIndex]);
            }
        }
        
        
        #region  *** Override of Object.Equals() for testing classes to use only ***
        public override bool Equals(dynamic input)
        {
            for (int rowNumber = 0; rowNumber < _squareSize; rowNumber++)
            {
                if (!CheckEqualityOfIndividualRows(input, rowNumber)) return false;
            }
            return true;
        }

        private bool CheckEqualityOfIndividualRows(Moves[][] input, int rowNumber)
        {
            for (int j = 0; j < _squareSize; j++)
            {
                if (_gameArray[rowNumber][j] != input[rowNumber][j])
                    return false;
            }
            return true;
        }
#endregion
    }
}
