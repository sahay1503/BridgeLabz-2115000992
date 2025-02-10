namespace RideHailingApp
{
    // Concrete class for Bike
    public class Bike : Vehicle, IGPS
    {
        private string currentLocation;

        public Bike(string vehicleId, string driverName, double ratePerKm, string location)
            : base(vehicleId, driverName, ratePerKm)
        {
            currentLocation = location;
        }

        // Override method to calculate fare for Bike (cheaper than Car)
        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm * 0.9; // 10% discount for bike rides
        }

        // Implement GPS interface methods
        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine($"Bike location updated to: {newLocation}");
        }
    }
}