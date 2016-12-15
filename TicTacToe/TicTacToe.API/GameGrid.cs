using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.API
{
    public class GameGrid
    {
        private Moves[][] _gameArray;
        private static int _squareSize;

        private delegate void NewMoveAssignmentDelegate(ref Moves newMove);

        private delegate bool ComparisonDelegate(Moves toCompare, Moves compareAgainst);

        public GameGrid(int numberOfRowsAndColumns)
        {
            _squareSize = numberOfRowsAndColumns;
            _gameArray = new Moves[numberOfRowsAndColumns][];
            IterateOverGameGrid(GetBlank);
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
            for (int rowIndex = 0; rowIndex < _squareSize; rowIndex++)
            {
                takeTheRowAndApply.Invoke(ref _gameArray[rowNumber][rowIndex]);
            }
        }

        public bool CheckEquality(Moves[][] input)
        {
            for (int i = 0; i < _squareSize; i++)
            {
                for (int j = 0; j < _squareSize; j++)
                {
                    if (_gameArray[i][j] != input[i][j])
                        return false;
                }
            }
            return true;
        }
    }
}
