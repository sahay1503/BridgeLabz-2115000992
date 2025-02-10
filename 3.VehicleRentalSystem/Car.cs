namespace VehicleRentalSystem
{
    // Concrete class for Cars, implementing IInsurable
    public class Car : Vehicle, IInsurable
    {
        private string insurancePolicyNumber; // Private field for insurance details

        public Car(string vehicleNumber, double rentalRate, string policyNumber)
            : base(vehicleNumber, "Car", rentalRate)
        {
            insurancePolicyNumber = policyNumber; // Assign policy number (kept private)
        }

        // Override method to calculate rental cost (fixed rate per day)
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        // Implement insurance cost calculation (e.g., 2% of rental cost)
        public double CalculateInsurance()
        {
            return RentalRate * 0.02;
        }

        // Get insurance details (policy number is hidden for security)
        public string GetInsuranceDetails()
        {
            return "Car Insurance: Standard Coverage (Policy Details Hidden)";
        }
    }
}