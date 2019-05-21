using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewChallenges
{
    public class FindTheKthLargestElement
    {
        /*  Find the kth largest element in an unsorted array. 
         *  This will be the kth largest element in sorted order, 
         *  not the kth distinct element.
        */

        public int FindKthLargestElement(int[] nums, int k)
        {
            Array.Sort(nums);
            Stack<int> numsSorted = new Stack<int>(nums);

            for (int numbersToPop = 0; numbersToPop < k - 1; numbersToPop++)
            {
                numsSorted.Pop();
            }

            return numsSorted.Pop();
        }
    }
}
