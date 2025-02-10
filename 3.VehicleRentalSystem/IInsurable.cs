namespace VehicleRentalSystem
{
    // Interface for insurable vehicles
    public interface IInsurable
    {
        double CalculateInsurance();  // Method to calculate insurance cost
        string GetInsuranceDetails(); // Method to get insurance details
    }

}