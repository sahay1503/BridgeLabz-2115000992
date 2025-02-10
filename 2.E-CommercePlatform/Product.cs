namespace ECommercePlatform
{
    // Abstract base class for all products
    public abstract class Product
    {
        // Private fields to store product details
        private int productId;
        private string name;
        private double price;

        // Public property for Product ID (read-only)
        public int ProductId
        {
            get { return productId; }
            private set { productId = value; }
        }

        // Public property for Name (read-only)
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        // Public property for Price (read/write to allow updates)
        public double Price
        {
            get { return price; }
            set { price = value; }  // Allowing price updates
        }

        // Constructor to initialize a product
        public Product(int id, string name, double price)
        {
            productId = id;   // Assign Product ID
            Name = name;      // Assign Name
            Price = price;    // Assign Price
        }

        // Abstract method to calculate discount (implemented in derived classes)
        public abstract double CalculateDiscount();

        // Virtual method to display product details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {ProductId}, Name: {Name}, Price: {Price:C}, Discount: {CalculateDiscount():C}");
        }
    }

}