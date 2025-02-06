using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Creating bank object
        Bank bank1 = new Bank("National Bank");

        // Creating customers
        Customer customer1 = new Customer("Vaibhav Singh");
        Customer customer2 = new Customer("Aditya Chaudhary");

        // Opening accounts for customers
        bank1.OpenAccount(customer1, 5000);
        bank1.OpenAccount(customer2, 3000);

        // Displaying customers and balances
        bank1.DisplayCustomers();
    }
}
