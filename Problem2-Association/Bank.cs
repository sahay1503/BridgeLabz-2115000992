
// Bank class (Associates with Customers)
class Bank
{
    public string Name { get; set; }
    public List<Customer> Customers { get; set; } = new List<Customer>();

    public Bank(string name)
    {
        Name = name;
    }

    public void OpenAccount(Customer customer, double initialBalance)
    {
        Account newAccount = new Account(this, initialBalance);
        customer.AddAccount(newAccount);
        if (!Customers.Contains(customer))
        {
            Customers.Add(customer);
        }
    }

    public void DisplayCustomers()
    {
        Console.WriteLine($"Bank: {Name}");
        foreach (var customer in Customers)
        {
            customer.ViewBalance();
        }
    }
}