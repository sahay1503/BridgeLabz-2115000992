using System;
using System.Collections.Generic;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of bank accounts (polymorphism in action)
            List<BankAccount> accounts = new List<BankAccount>
            {
                new SavingsAccount("SA123", "Aditya Saxena", 5000),
                new CurrentAccount("CA456", "Harsh Sahay", 10000)
            };

            // Perform operations on each account
            foreach (var account in accounts)
            {
                account.DisplayDetails();

                // Deposit money
                account.Deposit(2000);

                // Withdraw money
                account.Withdraw(3000);

                // Calculate and display interest
                double interest = account.CalculateInterest();
                Console.WriteLine($"Interest Earned: {interest:C}");

                // Check if account supports loans
                if (account is ILoanable loanableAccount)
                {
                    Console.WriteLine($"Loan Eligibility: {loanableAccount.CalculateLoanEligibility():C}");
                    loanableAccount.ApplyForLoan(5000); // Try applying for a loan
                }

                Console.WriteLine(); 
            }
        }
    }
}
