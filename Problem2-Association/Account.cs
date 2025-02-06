//Class Account
using System;

// Represents a bank account that links a customer to a bank
class Account
{
    // The bank where this account is held
    public Bank Bank { get; set; }

    // The current balance in the account
    public double Balance { get; set; }

    // Constructor to initialize an account with a bank and an initial balance
    public Account(Bank bank, double initialBalance)
    {
        Bank = bank;
        Balance = initialBalance;
    }

    // Displays account details, including the bank name and balance
    public void Display()
    {
        Console.WriteLine($"Bank: {Bank.Name}, Balance: Rs.{Balance}");
    }
}
