using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class DuplicateElements
    {
        bool ContainsDuplicates(int[] a)
        {
            int aLength = a.Length;
            IEnumerable<int> distinctNums = a.Distinct<int>();
            int distinctLength = distinctNums.Count();

            if (aLength > distinctLength)
                return true;
            return false;
        }
    }
}
