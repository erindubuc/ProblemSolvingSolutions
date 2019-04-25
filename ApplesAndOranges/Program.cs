using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesAndOranges
{
    class Program
    {
        // Complete the countApplesAndOranges function below.
        static void CountApplesAndOranges(int startOfHouse, int endOfHouse, int appleTree, int orangeTree, 
            int[] apples, int[] oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;

            for (int appleIndex = 0; appleIndex < apples.Length; appleIndex++)
            {
                int distanceLanded = apples[appleIndex] + appleTree;

                if (distanceLanded >= startOfHouse && distanceLanded <= endOfHouse)
                    appleCount++;
            }

            for (int orangeIndex = 0; orangeIndex < oranges.Length; orangeIndex++)
            {
                int distanceLanded = oranges[orangeIndex] + orangeTree;

                if (distanceLanded >= startOfHouse && distanceLanded <= endOfHouse)
                    orangeCount++;
            }

            Console.WriteLine($"{appleCount}");
            Console.WriteLine($"{orangeCount}");

        }
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int startOfHouse = Convert.ToInt32(st[0]);

            int endOfHouse = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int appleTree = Convert.ToInt32(ab[0]);

            int orangeTree = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            CountApplesAndOranges(startOfHouse, endOfHouse, appleTree, orangeTree, apples, oranges);
        }


    }
}
    

