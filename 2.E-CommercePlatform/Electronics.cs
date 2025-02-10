namespace ECommercePlatform
{
    // Concrete class for Electronics, implementing ITaxable
    public class Electronics : Product, ITaxable
    {
        public Electronics(int id, string name, double price) : base(id, name, price) { }

        // Override method to calculate discount (e.g., 10% off)
        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }

        // Implement tax calculation (e.g., 18% GST)
        public double CalculateTax()
        {
            return Price * 0.18;
        }

        // Get tax details
        public string GetTaxDetails()
        {
            return "Electronics Tax: 18% GST";
        }
    }
}