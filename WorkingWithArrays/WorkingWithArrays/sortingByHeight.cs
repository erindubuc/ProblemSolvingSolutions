using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class SortingByHeight
    {
        /*  Some people are standing in a row in a park. There are 
         *  trees between them which cannot be moved. Your task is 
         *  to rearrange the people by their heights in a non-descending 
         *  order without moving the trees. People can be very tall!
        */
        int[] SortByHeight(int[] peopleAndTrees)
        {
            int[] sorted = new int[peopleAndTrees.Length];
            Array.Copy(peopleAndTrees, sorted, peopleAndTrees.Length);
            Array.Sort(sorted);

            int sortIndex = sorted.Length - 1;

            for (int index = peopleAndTrees.Length - 1; index >= 0; index--)
            {
                if (peopleAndTrees[index] != -1)
                {
                    peopleAndTrees[index] = sorted[sortIndex];
                    sortIndex--;
                }
            }
            return peopleAndTrees;
        }
    }
}
