namespace UberFareEstimator
{
    public class UberRide 
    {
        public int TimeLengthRide;
        public int DistanceOfRide;
        
        double CostPerMinute;
        double CostPerMile;

        public UberRide(double costPerMin, double costPerMile)
        {
            this.CostPerMinute = costPerMin;
            this.CostPerMile = costPerMile;
        }

        public double UberFareEstimator(int ride_time, int ride_distance)
        {
            TimeLengthRide = ride_time;
            DistanceOfRide = ride_distance;
            
            return (ride_time) * (CostPerMinute) + (ride_distance) * (CostPerMile);
        }

    }
}
