using System;
using System.Collections.Generic;
using System.Linq;

class BankingSystem
{
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>();
    private Queue<(int, double)> withdrawalQueue = new Queue<(int, double)>();

    public void CreateAccount(int accountNumber, double initialBalance)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            Console.WriteLine($"Account {accountNumber} already exists!");
        }
        else
        {
            accountBalances[accountNumber] = initialBalance;
            Console.WriteLine($"Account {accountNumber} created with balance Rs.{initialBalance:F2}");
        }
    }

    public void Deposit(int accountNumber, double amount)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            accountBalances[accountNumber] += amount;
            Console.WriteLine($"Deposited Rs.{amount:F2} into Account {accountNumber}. New Balance: Rs.{accountBalances[accountNumber]:F2}");
        }
        else
        {
            Console.WriteLine($"Account {accountNumber} does not exist!");
        }
    }

    public void RequestWithdrawal(int accountNumber, double amount)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            withdrawalQueue.Enqueue((accountNumber, amount));
            Console.WriteLine($"Withdrawal request for Rs.{amount:F2} from Account {accountNumber} added to queue.");
        }
        else
        {
            Console.WriteLine($"Account {accountNumber} does not exist!");
        }
    }

    public void ProcessWithdrawals()
    {
        Console.WriteLine("\nProcessing Withdrawal Requests...");
        while (withdrawalQueue.Count > 0)
        {
            var (accountNumber, amount) = withdrawalQueue.Dequeue();

            if (accountBalances[accountNumber] >= amount)
            {
                accountBalances[accountNumber] -= amount;
                Console.WriteLine($"Withdrawal of Rs.{amount:F2} from Account {accountNumber} successful. New Balance: Rs.{accountBalances[accountNumber]:F2}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in Account {accountNumber} for withdrawal of Rs.{amount:F2}.");
            }
        }
    }

    public void DisplaySortedBalances()
    {
        SortedDictionary<double, List<int>> sortedAccounts = new SortedDictionary<double, List<int>>();

        foreach (var account in accountBalances)
        {
            if (!sortedAccounts.ContainsKey(account.Value))
                sortedAccounts[account.Value] = new List<int>();

            sortedAccounts[account.Value].Add(account.Key);
        }

        Console.WriteLine("\nAccounts Sorted by Balance:");
        foreach (var balanceGroup in sortedAccounts)
        {
            foreach (var acc in balanceGroup.Value)
            {
                Console.WriteLine($"Account {acc}: ${balanceGroup.Key:F2}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        BankingSystem bank = new BankingSystem();

        while (true)
        {
            Console.WriteLine("\nBanking System Menu:");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Request Withdrawal");
            Console.WriteLine("4. Process Withdrawals");
            Console.WriteLine("5. Display Sorted Balances");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Account Number: ");
                    int accNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter Initial Balance: ");
                    double balance = double.Parse(Console.ReadLine());
                    bank.CreateAccount(accNum, balance);
                    break;

                case "2":
                    Console.Write("Enter Account Number: ");
                    accNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter Deposit Amount: ");
                    double deposit = double.Parse(Console.ReadLine());
                    bank.Deposit(accNum, deposit);
                    break;

                case "3":
                    Console.Write("Enter Account Number: ");
                    accNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter Withdrawal Amount: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    bank.RequestWithdrawal(accNum, withdraw);
                    break;

                case "4":
                    bank.ProcessWithdrawals();
                    break;

                case "5":
                    bank.DisplaySortedBalances();
                    break;

                case "6":
                    Console.WriteLine("Exiting Banking System...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
