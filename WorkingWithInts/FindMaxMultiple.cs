using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInts
{
    /* Given a divisor and a bound, find the largest integer N such that:

        N is divisible by divisor.
        N is less than or equal to bound.
        N is greater than 0.
        It is guaranteed that such a number exists.
    */
    public class FindMaxMultiple
    {
        public int MaxMultiple(int divisor, int bound)
        {
            int multiple = 0;

            for (int findMultiple = bound; findMultiple > 0; findMultiple--)
            {

                if (findMultiple % divisor == 0)
                    return findMultiple;
            }

            return multiple;
        }
    }
}
