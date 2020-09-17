using System;
using System.Collections.Generic;
using System.Text;

namespace SuDoKu
{
    public partial class SudokuGame :IGet
    {
        //Realize interface IGet.
        //Get a value by Column
        public int GetByColumn(int columnIndex, int rowIndex)
        {
            arrayIndex = columnIndex + rowIndex * maxValue;
            return sudokuArray[arrayIndex];
        }

        //Get a value by Row
        public int GetByRow(int rowIndex, int columnIndex)
        {
            arrayIndex = columnIndex + rowIndex * maxValue;
            return sudokuArray[arrayIndex];
        }

        //Get a value by Square
        public int GetBySquare(int squareIndex, int positionIndex)
        {
            int colInd;
            int rowInd;
            colInd = (squareIndex % (maxValue / squareWidth)) * squareWidth + (positionIndex % squareWidth);
            rowInd = (squareIndex / (maxValue / squareWidth)) * squareHeight + (positionIndex / squareWidth);
            arrayIndex = colInd + rowInd * maxValue;
            return sudokuArray[arrayIndex];
        }

    }
}
