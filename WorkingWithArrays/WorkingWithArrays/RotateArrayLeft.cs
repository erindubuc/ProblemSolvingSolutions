using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    class RotateArrayLeft
    {
        static int[]RotateLeft(int[] arrayToShift, int numOfRotations)
        {

            Queue<int> arrayQ = new Queue<int>(arrayToShift.ToList());

            while (numOfRotations-- > 0)
            {
                arrayQ.Enqueue(arrayQ.Dequeue());
            }
            return arrayQ.ToArray();
        }
    }
}
