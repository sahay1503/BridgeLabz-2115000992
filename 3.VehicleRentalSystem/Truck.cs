namespace VehicleRentalSystem
{
    // Concrete class for Trucks (No insurance implementation)
    public class Truck : Vehicle
    {
        public Truck(string vehicleNumber, double rentalRate)
            : base(vehicleNumber, "Truck", rentalRate) { }

        // Override method to calculate rental cost (higher rate for trucks)
        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) * 1.2; // 20% extra charge for heavy-duty trucks
        }
    }
}