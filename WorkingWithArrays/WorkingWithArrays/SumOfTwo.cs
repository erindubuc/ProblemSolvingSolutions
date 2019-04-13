using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class SumOfTwo
    {
        bool SumOfTwoArrayIndexes(int[] a, int[] b, int v)
        {

            var hashSet = new HashSet<int>(a);

            int temp = 0;

            for (int bIndex = 0; bIndex < b.Length; bIndex++)
            {
                temp = v - b[bIndex];

                if (hashSet.Contains(temp))
                    return true;
            }

            return false;
        }
    }
}
