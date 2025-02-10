namespace BankingSystem
{
    // Interface for loanable accounts
    public interface ILoanable
    {
        bool ApplyForLoan(double amount);  // Method to apply for a loan
        double CalculateLoanEligibility(); // Method to check loan eligibility
    }

}