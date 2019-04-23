using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInts
{
    /* Consider integer numbers from 0 to n - 1 written down along the circle 
     * in such a way that the distance between any two neighboring numbers is 
     * equal (note that 0 and n - 1 are neighboring, too).

       Given n and firstNumber, find the number which is written in the radially 
       opposite position to firstNumber.
    */

    public class CircleOfNumbers
    {
        public int FindRadiallyOppositeInCircleOfNumbers(int numbersInAll, int firstNumber)
        {
            int radiallyOpposite;

            if (numbersInAll % 2 == 0 && firstNumber < (numbersInAll / 2))
                radiallyOpposite = firstNumber + (numbersInAll / 2);
            else
                radiallyOpposite = (numbersInAll / 2) - (numbersInAll - firstNumber);

            return radiallyOpposite;
        }
    }
}
