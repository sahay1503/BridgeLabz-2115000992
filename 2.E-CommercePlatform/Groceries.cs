namespace ECommercePlatform
{
    // Concrete class for Groceries (No tax applicable)
    public class Groceries : Product
    {
        public Groceries(int id, string name, double price) : base(id, name, price) { }

        // Override method to calculate discount (e.g., 5% off)
        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }
    }
}