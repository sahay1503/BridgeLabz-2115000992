namespace VehicleRentalSystem
{
    // Abstract base class for all vehicles
    public abstract class Vehicle
    {
        // Private fields to store vehicle details
        private string vehicleNumber;
        private string type;
        private double rentalRate;

        // Public property for Vehicle Number (read-only)
        public string VehicleNumber
        {
            get { return vehicleNumber; }
            private set { vehicleNumber = value; }
        }

        // Public property for Type (read-only)
        public string Type
        {
            get { return type; }
            private set { type = value; }
        }

        // Public property for Rental Rate (read-only)
        public double RentalRate
        {
            get { return rentalRate; }
            private set { rentalRate = value; }
        }

        // Constructor to initialize a vehicle
        public Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            this.vehicleNumber = vehicleNumber;  // Assign vehicle number
            Type = type;                         // Assign type (Car, Bike, Truck, etc.)
            RentalRate = rentalRate;             // Assign rental rate per day
        }

        // Abstract method to calculate rental cost (implemented in derived classes)
        public abstract double CalculateRentalCost(int days);

        // Virtual method to display vehicle details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Vehicle No: {VehicleNumber}, Type: {Type}, Rental Rate: {RentalRate:C}/day");
        }
    }

}