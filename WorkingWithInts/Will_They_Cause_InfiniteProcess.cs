using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInts
{
    public class Will_They_Cause_InfiniteProcess
    {
        /*  Given integers a and b, determine whether the 
         *  following pseudocode results in an infinite loop:

            while a is not equal to b do
              increase a by 1
              decrease b by 1
        */
        public bool IsInfiniteProcess(int a, int b)
        {
            if (a == b)
                return false;

            if (a > b)
                return true;

            if (a < b)
            {
                if ((b - a) % 2 == 0)
                    return false;
            }

            return true;
        }
    }
}
