using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInts
{
    public class SeatsInATheater
    {
        /* Given the total number of rows and columns in the theater (nRows and nCols, respectively), 
         * and the row and column you're sitting in, return the 
         * number of people who sit strictly behind you and in your column or to the left, 
         * assuming all seats are occupied.
        */
        public int HowManySeatsInTheater(int nCols, int nRows, int col, int row)
        {
            int numOfSeatsInAll = 0;
            int totalSeatsInTheater = nCols * nRows;
            int colsToLeft = (nRows - row) * (col - 1);
            int rowsBehind = row * nCols;

            if (totalSeatsInTheater == 1)
                numOfSeatsInAll = 0;

            else
                numOfSeatsInAll = totalSeatsInTheater - (colsToLeft + rowsBehind);

            return numOfSeatsInAll;
        }
    }
}
