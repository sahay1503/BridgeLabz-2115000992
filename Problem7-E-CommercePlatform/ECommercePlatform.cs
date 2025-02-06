//Class ECommercePlatform
using System;
using System.Collections.Generic;

// Represents an e-commerce platform that manages customers and their orders
class ECommercePlatform
{
    // The name of the e-commerce platform
    public string Name { get; set; }

    // List of customers registered on the platform
    public List<Customer> Customers { get; set; }

    // Constructor to initialize the platform with a name
    public ECommercePlatform(string name)
    {
        // Set the name of the platform
        Name = name;

        // Initializes an empty list of customers on the platform
        Customers = new List<Customer>();
    }

    // Adds a customer to the platform's list of customers
    public void AddCustomer(Customer customer)
    {
        // Add the customer to the platform’s customer list
        Customers.Add(customer);
    }

    // Displays all customers and their orders on the platform
    public void DisplayPlatform()
    {
        // Print the platform's name
        Console.WriteLine($"E-Commerce Platform: {Name}");

        // Loop through each customer and display their orders
        foreach (var customer in Customers)
        {
            // Display each customer's orders
            customer.DisplayOrders();
        }
    }
}
