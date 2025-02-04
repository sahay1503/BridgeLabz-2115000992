using System;

// Class representing a bank account
public class BankAccount
{
    // Static variable shared across all instances, representing the bank name
    public static string bankName = "Indian Overseas Bank";

    // Readonly field for account number (cannot be modified after initialization)
    public readonly int accountNumber;

    // Static variable to keep track of the total number of bank accounts created
    private static int totalAccounts = 0;

    // Private field to store the account holder's name
    private string accountHolderName;

    // Constructor to initialize a bank account with account holder's name and account number
    public BankAccount(string accountHolderName, int accountNumber)
    {
        this.accountNumber = accountNumber; // Assign the account number
        this.accountHolderName = accountHolderName; // Assign the account holder's name
        totalAccounts++; // Increment the total number of accounts
    }

    // Static method to display the total number of accounts created
    public static void GetTotalAccounts()
    {
        Console.WriteLine($"Total Accounts: {totalAccounts}");
    }

    // Method to display the details of a specific bank account
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Bank: {bankName}");
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Account Holder Name: {accountHolderName}");
    }
}
