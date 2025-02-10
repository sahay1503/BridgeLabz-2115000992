namespace OnlineFoodDeliverySystem
{
    // Abstract base class for all food items
    public abstract class FoodItem
    {
        // Private fields to store food details
        private string itemName;
        private double price;
        private int quantity;

        // Public property for Item Name (read-only)
        public string ItemName
        {
            get { return itemName; }
            private set { itemName = value; }
        }

        // Public property for Price (read-only)
        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        // Public property for Quantity (read/write)
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value > 0 ? value : 1; } // Ensure quantity is always at least 1
        }

        // Constructor to initialize a food item
        public FoodItem(string itemName, double price, int quantity)
        {
            this.itemName = itemName;
            this.price = price;
            Quantity = quantity;
        }

        // Abstract method to calculate total price (implemented in derived classes)
        public abstract double CalculateTotalPrice();

        // Method to display item details
        public virtual void GetItemDetails()
        {
            Console.WriteLine($"Item: {ItemName}, Price: {Price:C}, Quantity: {Quantity}");
        }
    }

}