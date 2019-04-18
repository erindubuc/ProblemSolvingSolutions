using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = LargestNumber(number);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int LargestNumber(int n)
        {
            int largest = 9;

            for (int digits = 1; digits < n; digits++)
            {
                largest = (largest * 10) + 9;
            }
            return largest;
        }
    }
}
