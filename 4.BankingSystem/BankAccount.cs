namespace BankingSystem
{
    // Abstract base class for all bank accounts
    public abstract class BankAccount
    {
        // Private fields to store account details
        private string accountNumber;
        private string holderName;
        private double balance;

        // Public property for Account Number (read-only)
        public string AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }

        // Public property for Holder Name (read-only)
        public string HolderName
        {
            get { return holderName; }
            private set { holderName = value; }
        }

        // Public property for Balance (restricted access)
        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }  // Protected so only derived classes can modify it
        }

        // Constructor to initialize a bank account
        public BankAccount(string accountNumber, string holderName, double initialBalance)
        {
            this.accountNumber = accountNumber;  // Assign account number
            HolderName = holderName;             // Assign holder name
            Balance = initialBalance;            // Assign initial balance
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Method to withdraw money from the account
        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. Remaining Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }

        // Abstract method to calculate interest (implemented in derived classes)
        public abstract double CalculateInterest();

        // Virtual method to display account details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account No: {AccountNumber}, Holder: {HolderName}, Balance: {Balance:C}");
        }
    }
}