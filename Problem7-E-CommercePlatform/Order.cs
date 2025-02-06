//class Order
using System;
using System.Collections.Generic;
// Represents an order that contains multiple products, associated with a customer
class Order
{
    // The unique identifier for the order
    public int OrderId { get; set; }

    // The customer who placed the order
    public Customer Customer { get; set; }

    // List of products in the order
    public List<Product> Products { get; set; }

    // Constructor to initialize the order with an ID and a customer
    public Order(int orderId, Customer customer)
    {
        // Set the order ID
        OrderId = orderId;

        // Set the customer who placed the order
        Customer = customer;

        // Initializes an empty list of products in the order
        Products = new List<Product>();
    }

    // Adds a product to the order
    public void AddProduct(Product product)
    {
        // Add the product to the list of products in the order
        Products.Add(product);
    }

    // Displays the details of the order including its products
    public void DisplayOrder()
    {
        // Print the order ID and the customer who placed the order
        Console.WriteLine($"Order ID: {OrderId}, Customer: {Customer.Name}");

        // Loop through each product in the order and display its details
        foreach (var product in Products)
        {
            product.Display(); // Display each product’s details
        }
    }
}
