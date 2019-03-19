using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(ReversedOrder(num));
            Console.ReadLine();
        }

        public static int ReversedOrder(int num)
        {
            int reversed = 0;

            while (num != 0)
            {
                reversed = reversed * 10 + num % 10;
                //Console.WriteLine(reversed);
                //Console.WriteLine("num: {0}", num);

                // takes num every iteration and divides by 10 -> takes last digit off
                num = num / 10;
            }
            return reversed;
        }
    }
}
