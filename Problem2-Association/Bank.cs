//Class Bank
using System;
using System.Collections.Generic;
// Represents a bank that manages customers and their accounts
class Bank
{
    // Stores the bank's name
    public string Name { get; set; }

    // List of customers associated with the bank
    public List<Customer> Customers { get; set; } = new List<Customer>();

    // Constructor to initialize the bank with a name
    public Bank(string name)
    {
        Name = name;
    }

    // Opens a new account for a customer with an initial balance
    public void OpenAccount(Customer customer, double initialBalance)
    {
        Account newAccount = new Account(this, initialBalance); // Creates a new account linked to this bank
        customer.AddAccount(newAccount); // Adds the account to the customer

        // If the customer is not already registered with the bank, add them
        if (!Customers.Contains(customer))
        {
            Customers.Add(customer);
        }
    }

    // Displays all customers and their account details
    public void DisplayCustomers()
    {
        Console.WriteLine($"Bank: {Name}");

        // Loop through each customer and display their details
        foreach (var customer in Customers)
        {
            customer.ViewBalance();
        }
    }
}
