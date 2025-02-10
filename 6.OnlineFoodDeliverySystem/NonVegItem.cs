namespace OnlineFoodDeliverySystem
{
    // Concrete class for Non-Vegetarian Items
    public class NonVegItem : FoodItem, IDiscountable
    {
        private double discountApplied = 0; // Store applied discount
        private double additionalCharge = 10; // Additional charge per item

        public NonVegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity) { }

        // Override method to calculate total price (Includes additional charge)
        public override double CalculateTotalPrice()
        {
            return ((Price + additionalCharge) * Quantity) * (1 - discountApplied / 100);
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