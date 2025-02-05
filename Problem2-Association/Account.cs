// Account class (Links Bank and Customers)
class Account
{
    public Bank Bank { get; set; }
    public double Balance { get; set; }

    public Account(Bank bank, double initialBalance)
    {
        Bank = bank;
        Balance = initialBalance;
    }

    public void Display()
    {
        Console.WriteLine($"Bank: {Bank.Name}, Balance: Rs.{Balance}");
    }
}
