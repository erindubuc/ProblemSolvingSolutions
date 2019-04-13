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

            var hashSetA = new HashSet<int>(a);

            int addend = 0;

            for (int bIndex = 0; bIndex < b.Length; bIndex++)
            {
                addend = v - b[bIndex];

                if (hashSetA.Contains(addend))
                    return true;
            }

            return false;
        }
    }
}
