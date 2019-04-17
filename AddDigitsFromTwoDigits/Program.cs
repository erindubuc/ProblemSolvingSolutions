using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigitsFromTwoDigits
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = addTwoDigits(number);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int addTwoDigits(int n)
        {
            int firstDigit = n / 10;
            int secondDigit = n % 10;

            return firstDigit + secondDigit;
        }

    }

}
