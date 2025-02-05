// Customer class (Associates with Bank and Accounts)
class Customer
{
    public string Name { get; set; }
    public List<Account> Accounts { get; set; } = new List<Account>();

    public Customer(string name)
    {
        Name = name;
    }

    public void AddAccount(Account account)
    {
        Accounts.Add(account);
    }

    public void ViewBalance()
    {
        Console.WriteLine($"Customer: {Name}");
        foreach (var account in Accounts)
        {
            account.Display();
        }
    }
}
