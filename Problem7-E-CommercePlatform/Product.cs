//class Product
using System;
// Represents a product that is aggregated in an order
class Product
{
    // The name of the product
    public string Name { get; set; }

    // The price of the product
    public double Price { get; set; }

    // Constructor to initialize the product with a name and price
    public Product(string name, double price)
    {
        // Set the product's name
        Name = name;

        // Set the product's price
        Price = price;
    }

    // Displays the product's details including its name and price
    public void Display()
    {
        // Print the product's name and price
        Console.WriteLine($"Product: {Name}, Price: Rs.{Price}");
    }
}
