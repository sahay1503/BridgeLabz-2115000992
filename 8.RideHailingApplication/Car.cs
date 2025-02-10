namespace RideHailingApp
{
    // Concrete class for Car
    public class Car : Vehicle, IGPS
    {
        private string currentLocation;

        public Car(string vehicleId, string driverName, double ratePerKm, string location)
            : base(vehicleId, driverName, ratePerKm)
        {
            currentLocation = location;
        }

        // Override method to calculate fare for Car (includes base rate)
        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        // Implement GPS interface methods
        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine($"Car location updated to: {newLocation}");
        }
    }

}