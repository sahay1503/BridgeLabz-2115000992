namespace ECommercePlatform
{

    // Concrete class for Clothing, implementing ITaxable
    public class Clothing : Product, ITaxable
    {
        public Clothing(int id, string name, double price) : base(id, name, price) { }

        // Override method to calculate discount (e.g., 15% off)
        public override double CalculateDiscount()
        {
            return Price * 0.15;
        }

        // Implement tax calculation (e.g., 5% VAT)
        public double CalculateTax()
        {
            return Price * 0.05;
        }

        // Get tax details
        public string GetTaxDetails()
        {
            return "Clothing Tax: 5% VAT";
        }
    }
}