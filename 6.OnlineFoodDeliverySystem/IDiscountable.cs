namespace IDiscountable
{
    // Interface for discountable items
    public interface IDiscountable
    {
        void ApplyDiscount(double percentage); // Method to apply discount
        string GetDiscountDetails();          // Method to get discount details
    }
}