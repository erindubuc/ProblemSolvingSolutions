using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class RotateClockwise
    {
        int[][] RotateImageClockwise(int[][] a)
        {

            // Declare matrix with size of rows in a
            int[][] finalImage = new int[a.Length][];

            // Initialize rows in new array -could be jagged
            for (int row = 0; row < finalImage.Length; row++)
            {
                finalImage[row] = new int[a.Length];
            }

            // Copy old array over into new array
            for (int newRow = 0; newRow < a.Length; newRow++)
            {
                // Grab last column to start rotation
                int lastColumn = a.Length - 1;

                for (int newCol = 0; newCol < a.Length; newCol++)
                {
                    finalImage[newRow][newCol] = a[lastColumn][newRow];
                    lastColumn--;
                }
            }

            return finalImage;
        }
    }
}
