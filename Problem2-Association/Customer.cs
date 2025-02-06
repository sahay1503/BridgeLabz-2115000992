//Class Customer
using System;
using System.Collections.Generic;

// Represents a bank customer who owns multiple accounts
class Customer
{
    // Stores the customer's name
    public string Name { get; set; }

    // List of accounts associated with the customer
    public List<Account> Accounts { get; set; } = new List<Account>();

    // Constructor to initialize the customer with a name
    public Customer(string name)
    {
        Name = name;
    }

    // Adds a new account to the customer's account list
    public void AddAccount(Account account)
    {
        Accounts.Add(account);
    }

    // Displays the customer's name and all associated account balances
    public void ViewBalance()
    {
        Console.WriteLine($"Customer: {Name}");

        // Loop through each account and display its details
        foreach (var account in Accounts)
        {
            account.Display();
        }
    }
}
