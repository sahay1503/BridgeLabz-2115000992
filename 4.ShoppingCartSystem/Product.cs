// Class representing a Product in the shopping cart
public class Product
{
    // Static variable shared across all instances, representing the discount percentage
    public static double Discount = 10.0; // Default discount of 10%

    // Readonly field for Product ID (cannot be modified after initialization)
    public readonly int ProductID;

    // Instance fields to store the product's name, price, and quantity
    private string ProductName;
    private double Price;
    private int Quantity;

    // Constructor to initialize a product with ProductName, Price, and Quantity
    public Product(int productID, string productName, double price, int quantity)
    {
        this.ProductID = productID; // Assign the unique product ID
        this.ProductName = productName; // Assign the product name
        this.Price = price; // Assign the price of the product
        this.Quantity = quantity; // Assign the quantity of the product
    }

    // Static method to update the discount percentage for all products
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine($"Discount updated to {Discount}% for all products.");
    }

    // Method to display product details including discount
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product ID: {ProductID}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Discount: {Discount}%");
        double finalPrice = Price - (Price * Discount / 100);
        Console.WriteLine($"Final Price after discount: ${finalPrice}");
    }

    // Method to validate whether an object is an instance of the Product class
    public static void DisplayIfProduct(object obj)
    {
        if (obj is Product product)
        {
            product.DisplayProductDetails();
        }
        else
        {
            Console.WriteLine("This is not a valid Product object.");
        }
    }
}
