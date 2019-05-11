using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInts
{
    public class PhoneCallMinutes
    {
        /* You have s cents on your account before the call. What is the 
         * duration of the longest call (in minutes rounded down to the 
         * nearest integer) you can have?
        */
        public int PhoneCall(int min1, int min2_10, int min11, int s)
        {
            int totalMinsCanTalk = 0;

            if (min1 == s)
                return 1;

            if (s < min1)
                return 0;

            if ((s - min1) < (min2_10 * 9))
            {
                for (int min = 8; min > 0; min--)
                {
                    totalMinsCanTalk = (s - min1) - (min2_10 * min);
                }

                return totalMinsCanTalk;
            }

            else
            {
                int moneyLeftAfterFirst10 = s - min1 - (min2_10 * 9);
                int finalMinsCanTalk = moneyLeftAfterFirst10 / min11;
                totalMinsCanTalk = 10 + finalMinsCanTalk;
            }

            return totalMinsCanTalk;
        }
    }
}
