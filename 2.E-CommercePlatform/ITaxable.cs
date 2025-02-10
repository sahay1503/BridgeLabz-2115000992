namespace ECommercePlatform
{
    // Interface for taxable products
    public interface ITaxable
    {
        double CalculateTax();  // Method to calculate tax
        string GetTaxDetails(); // Method to get tax details
    }

}