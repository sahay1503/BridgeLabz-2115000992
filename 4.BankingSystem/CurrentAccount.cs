namespace BankingSystem
{

    // Concrete class for Current Account (with overdraft facility)
    public class CurrentAccount : BankAccount
    {
        private double overdraftLimit = 10000; // Overdraft limit for current accounts

        public CurrentAccount(string accountNumber, string holderName, double initialBalance)
            : base(accountNumber, holderName, initialBalance) { }

        // Override method to calculate interest (Current accounts typically don't earn interest)
        public override double CalculateInterest()
        {
            return 0; // No interest for current accounts
        }

        // Override Withdraw method to allow overdraft
        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= (Balance + overdraftLimit))
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. Remaining Balance: {Balance:C} (Overdraft Used)");
            }
            else
            {
                Console.WriteLine("Withdrawal exceeds overdraft limit.");
            }
        }
    }

}