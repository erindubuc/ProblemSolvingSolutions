using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateRide
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What does the timer say?");
            int minutesPassed = int.Parse(Console.ReadLine());
            int result = LateRideCurrentTime(minutesPassed);

            Console.WriteLine($"Your ride took {minutesPassed} minutes and the sum of the timer's digits are {result}.");
            Console.ReadLine();
        }

        public static int LateRideCurrentTime(int minutesPassed)
        {
            int currentTime = ((minutesPassed / 60) / 10) + ((minutesPassed / 60) % 10) + ((minutesPassed % 60) / 10) + ((minutesPassed % 60) % 10);

            return currentTime;
        }
    }
}
