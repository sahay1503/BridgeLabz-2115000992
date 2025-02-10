namespace VehicleRentalSystem
{
    // Concrete class for Bikes, implementing IInsurable
    public class Bike : Vehicle, IInsurable
    {
        private string insurancePolicyNumber; // Private field for insurance details

        public Bike(string vehicleNumber, double rentalRate, string policyNumber)
            : base(vehicleNumber, "Bike", rentalRate)
        {
            insurancePolicyNumber = policyNumber; // Assign policy number (kept private)
        }

        // Override method to calculate rental cost (fixed rate per day with a discount)
        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) * 0.95; // 5% discount for bikes
        }

        // Implement insurance cost calculation (e.g., 1.5% of rental cost)
        public double CalculateInsurance()
        {
            return RentalRate * 0.015;
        }

        // Get insurance details
        public string GetInsuranceDetails()
        {
            return "Bike Insurance: Standard Coverage (Policy Details Hidden)";
        }
    }
}