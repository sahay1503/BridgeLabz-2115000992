namespace OnlineFoodDeliverySystem
{
    // Concrete class for Vegetarian Items
    public class VegItem : FoodItem, IDiscountable
    {
        private double discountApplied = 0; // Store applied discount

        public VegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity) { }

        // Override method to calculate total price (No additional charges for veg items)
        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) * (1 - discountApplied / 100);
        }

        // Implement discount interface methods
        public void ApplyDiscount(double percentage)
        {
            discountApplied = percentage;
        }

        public string GetDiscountDetails()
        {
            return discountApplied > 0 ? $"Discount Applied: {discountApplied}%" : "No discount applied.";
        }
    }
}