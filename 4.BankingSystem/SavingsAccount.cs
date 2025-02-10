namespace BankingSystem
{
    // Concrete class for Savings Account (with interest calculation)
    public class SavingsAccount : BankAccount, ILoanable
    {
        private double interestRate = 0.04; // 4% interest rate

        public SavingsAccount(string accountNumber, string holderName, double initialBalance)
            : base(accountNumber, holderName, initialBalance) { }

        // Override method to calculate interest
        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }

        // Implement loan eligibility (Savings accounts have lower loan eligibility)
        public double CalculateLoanEligibility()
        {
            return Balance * 2; // Loan eligibility = 2 times the balance
        }

        // Method to apply for a loan
        public bool ApplyForLoan(double amount)
        {
            if (amount <= CalculateLoanEligibility())
            {
                Console.WriteLine($"Loan of {amount:C} approved for Savings Account.");
                return true;
            }
            else
            {
                Console.WriteLine("Loan amount exceeds eligibility.");
                return false;
            }
        }
    }

}