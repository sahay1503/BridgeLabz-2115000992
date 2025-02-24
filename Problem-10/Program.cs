using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount! Please enter a positive value.");
        }
        if (amount > balance)
        {
            throw new InsufficientFundsException("Insufficient balance!");
        }

        balance -= amount;
        Console.WriteLine($"Withdrawal successful, new balance: {balance}");
    }

    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount! Please enter a positive value.");
        }

        balance += amount;
        Console.WriteLine($"Deposit successful, new balance: {balance}");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current balance: {balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = null;

        while (true)
        {
            Console.WriteLine("\nBank Transaction Menu:");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (account != null)
                    {
                        Console.WriteLine("An account already exists!");
                    }
                    else
                    {
                        Console.Write("Enter initial balance: ");
                        double initialBalance;

                        while (!double.TryParse(Console.ReadLine(), out initialBalance) || initialBalance < 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number.");
                            Console.Write("Enter initial balance: ");
                        }

                        account = new BankAccount(initialBalance);
                        Console.WriteLine("Account created successfully!");
                    }
                    break;

                case "2":
                    if (account == null)
                    {
                        Console.WriteLine("No account found! Please create an account first.");
                    }
                    else
                    {
                        try
                        {
                            Console.Write("Enter withdrawal amount: ");
                            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                            account.Withdraw(withdrawAmount);
                        }
                        catch (InsufficientFundsException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input! Please enter a numeric value.");
                        }
                    }
                    break;

                case "3":
                    if (account == null)
                    {
                        Console.WriteLine("No account found! Please create an account first.");
                    }
                    else
                    {
                        try
                        {
                            Console.Write("Enter deposit amount: ");
                            double depositAmount = Convert.ToDouble(Console.ReadLine());
                            account.Deposit(depositAmount);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input! Please enter a numeric value.");
                        }
                    }
                    break;

                case "4":
                    if (account == null)
                    {
                        Console.WriteLine("No account found! Please create an account first.");
                    }
                    else
                    {
                        account.CheckBalance();
                    }
                    break;

                case "5":
                    Console.WriteLine("Exiting program. Thank you for banking with us!");
                    return;

                default:
                    Console.WriteLine("Invalid option! Please select a valid choice.");
                    break;
            }
        }
    }
}
