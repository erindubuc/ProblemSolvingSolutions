using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class ConsecutiveIntegers
    {
        int MakeArrayConsecutive2(int[] statues)
        {
            List<int> newStatues = new List<int>();
            Array.Sort(statues);

            foreach (int statue in statues)
            {
                newStatues.Add(statue);
                //Console.WriteLine(statue);
            }

            int listCount = newStatues.Count();
            int firstNum = newStatues.First();
            int lastNum = newStatues.Last();

            int result = (lastNum - firstNum) + 1;

            if (listCount != result)
                return result - listCount;

            return 0;
        }

    }
}
