using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFareEstimator
{
    public class UberRide 
    {
        public int TimeLengthRide;
        public int DistanceOfRide;
        public double[] CostPerMinute;
        public double[] CostPerMile;

        public UberRide()
        {

        }

        public UberRide(int ride_length, int ride_distance, double[] costPerMin, double[] costPerMile)
        {
            TimeLengthRide = ride_length;
            DistanceOfRide = ride_distance;
            costPerMin = CostPerMinute;
            costPerMile = CostPerMile;
       
        }

        public double[] FareEstimator(UberRide rideData)
        {
            
            double[] totalFares = new double[CostPerMile.Length];
            double cost;

            for (int i = 0; i < CostPerMile.Length; i++)
            {
                cost = CostPerMinute[i] * TimeLengthRide + CostPerMile[i] * DistanceOfRide;
                totalFares[i] = cost;
            }

            return totalFares;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] costPerMin = { 0.2, 0.35, 0.4, 0.45 };
            double[] costPerMile = { 1.1, 1.8, 2.3, 3.5 };

            UberRide rideData = new UberRide(30, 7, costPerMin, costPerMile);
            double[] result = rideData.FareEstimator(rideData);

            for (int i = 0; i < costPerMile.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadLine();
        }

        
    }
}
