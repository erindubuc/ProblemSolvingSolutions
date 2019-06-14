using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class SumMatrixElements
    {
        /*  After becoming famous, the CodeBots decided to move into a new building 
         *  together. Each of the rooms has a different cost, and some of them are 
         *  free, but there's a rumour that all the free rooms are haunted! Since the 
         *  CodeBots are quite superstitious, they refuse to stay in any of the free 
         *  rooms, or any of the rooms below any of the free rooms.

            Given matrix, a rectangular matrix of integers, where each value represents 
            the cost of the room, your task is to return the total sum of all rooms that 
            are suitable for the CodeBots (ie: add up all the values that don't appear below 
            a 0).
        */

        int GetMatrixElementsSum(int[][] matrix)
        {
            int totalCostOfRooms = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 0 && row + 1 < matrix.Length)
                    {
                        matrix[row + 1][col] = 0;
                    }

                    totalCostOfRooms += matrix[row][col];
                }
            }

            return totalCostOfRooms;
        }
    }
}
