namespace RideHailingApp
{
    // Concrete class for Auto
    public class Auto : Vehicle, IGPS
    {
        private string currentLocation;

        public Auto(string vehicleId, string driverName, double ratePerKm, string location)
            : base(vehicleId, driverName, ratePerKm)
        {
            currentLocation = location;
        }

        // Override method to calculate fare for Auto (fixed minimum fare)
        public override double CalculateFare(double distance)
        {
            double fare = distance * RatePerKm;
            return fare < 50 ? 50 : fare; // Minimum fare is 50
        }

        // Implement GPS interface methods
        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine($"Auto location updated to: {newLocation}");
        }
    }
}