using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class AlmostIncreasingSequence
    {
        /* Given a sequence of integers as an array, determine 
             * whether it is possible to obtain a strictly increasing 
             * sequence by removing no more than one element from the array.
            */
        bool IsThisAnAlmostIncreasingSequence(int[] sequence)
        {
            int numbersRemoved = 0;
            int timesANumberWasRemoved = 0;

            for (int index = 0; index < sequence.Length - 1; index++)
            {
                if (sequence[index] >= sequence[index + 1])
                {
                    numbersRemoved++;
                    timesANumberWasRemoved++;

                    if (timesANumberWasRemoved > 1)
                        numbersRemoved++;
                }
                if (index + 2 < sequence.Length && sequence[index] >= sequence[index + 2])
                    numbersRemoved++;

            }
            if (numbersRemoved <= 2)
                return true;
            return false;
        }
    }
}
