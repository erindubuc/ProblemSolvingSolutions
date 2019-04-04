using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class AdjacentElementsProduct
    {
        /*
         * Given an array of integers, find the pair of adjacent elements 
         * that has the largest product and return that product.
        */
        int FindAdjacentElementsProduct(int[] inputArray)
        {
            int maxProduct = -1000;
            int tempProduct = 0;

            for (int inputs = 0; inputs < inputArray.Length - 1; inputs++)
            {
                tempProduct = inputArray[inputs] * inputArray[inputs + 1];

                if (tempProduct > maxProduct)
                    maxProduct = tempProduct;

            }

            return maxProduct;
        }
    }
}

