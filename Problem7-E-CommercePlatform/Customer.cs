//class Customer
using System;
using System.Collections.Generic;

// Represents a customer who can place orders
class Customer
{
    // The name of the customer
    public string Name { get; set; }

    // List of orders placed by the customer
    public List<Order> Orders { get; set; }

    // Constructor to initialize the customer with a name
    public Customer(string name)
    {
        // Initialize the customer's name
        Name = name;

        // Initializes an empty list of orders placed by the customer
        Orders = new List<Order>();
    }

    // Places an order and adds it to the list of orders
    public void PlaceOrder(Order order)
    {
        // Add the order to the customer's order list
        Orders.Add(order);
    }

    // Displays all orders placed by the customer
    public void DisplayOrders()
    {
        // Print the customer's name
        Console.WriteLine($"Customer: {Name}");

        // Loop through each order and display its details
        foreach (var order in Orders)
        {
            // Display the details of each order
            order.DisplayOrder();
        }
    }
}
