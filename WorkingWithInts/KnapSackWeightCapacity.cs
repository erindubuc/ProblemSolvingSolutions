using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInts
{
    class KnapSackWeightCapacity
    {
        /*  You found two items in a treasure chest! The first item weighs weight1 
         *  and is worth value1, and the second item weighs weight2 and is worth value2. 
         *  What is the total maximum value of the items you can take with you, 
         *  assuming that your max weight capacity is maxW and you can't come back for the items later?
        */
        int KnapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (weight1 + weight2 <= maxW)
                return value1 + value2;

            if (weight1 + weight2 >= maxW)
            {
                if (weight1 <= maxW && weight2 <= maxW)
                {
                    if (value1 > value2)
                        return value1;
                    else
                        return value2;
                }

                if (weight1 <= maxW)
                {
                    return value1;
                }

                if (weight2 <= maxW)
                {
                    return value2;
                }
            }

            return 0;

        }
    }
}
