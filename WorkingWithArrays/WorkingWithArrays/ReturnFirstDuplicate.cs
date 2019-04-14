using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class ReturnFirstDuplicate
    {
        int FirstDuplicate(int[] a)
        {
            int duplicate = -1;

            HashSet<int> possibleDup = new HashSet<int>();

            foreach (int value in a)
            {
                if (possibleDup.Contains(value))
                    return value;

                possibleDup.Add(value);
            }

            return duplicate;
        }
    }
}
