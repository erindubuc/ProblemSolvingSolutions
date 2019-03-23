using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFareEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            int TimeLengthRide = 30;
            int DistanceOfRide = 7;

            double[] cost_per_minute = { 0.2, 0.35, 0.4, 0.45 };
            double[] cost_per_mile = { 1.1, 1.8, 2.3, 3.5 };
            double[] totalFares = new double[cost_per_mile.Length];

            for (int ride = 0; ride < cost_per_mile.Length; ride++)
            {
                UberRide vehicle = new UberRide(cost_per_minute[ride], cost_per_mile[ride]);

                totalFares[ride] = vehicle.UberFareEstimator(TimeLengthRide, DistanceOfRide);

                Console.WriteLine($"This Uber will cost: {totalFares[ride]:C}");
                
            }
            
            Console.ReadLine();
        }

        
    }
}
