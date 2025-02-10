namespace RideHailingApp
{
    // Abstract base class for all vehicles
    public abstract class Vehicle
    {
        // Private fields to store vehicle details
        private string vehicleId;
        private string driverName;
        private double ratePerKm;

        // Public property for Vehicle ID (read-only)
        public string VehicleId
        {
            get { return vehicleId; }
            private set { vehicleId = value; }
        }

        // Public property for Driver Name (read-only)
        public string DriverName
        {
            get { return driverName; }
            private set { driverName = value; }
        }

        // Public property for Rate Per Km (read-only)
        public double RatePerKm
        {
            get { return ratePerKm; }
            private set { ratePerKm = value; }
        }

        // Constructor to initialize a vehicle
        public Vehicle(string vehicleId, string driverName, double ratePerKm)
        {
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
        }

        // Abstract method to calculate fare based on distance (implemented in derived classes)
        public abstract double CalculateFare(double distance);

        // Method to display vehicle details
        public virtual void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate per Km: {RatePerKm:C}");
        }
    }


}