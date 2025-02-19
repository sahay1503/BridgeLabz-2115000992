using System;
using System.Collections.Generic;

class ShoppingCart
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>();
    private LinkedList<string> purchaseOrder = new LinkedList<string>();
    private SortedDictionary<double, List<string>> sortedProducts = new SortedDictionary<double, List<string>>();

    public void AddProduct(string product, double price)
    {
        if (!productPrices.ContainsKey(product))
        {
            productPrices[product] = price;
            purchaseOrder.AddLast(product);
        }
        else
        {
            Console.WriteLine($"Warning: {product} already exists. Price remains the same.");
        }
        if (!sortedProducts.ContainsKey(price))
        {
            sortedProducts[price] = new List<string>();
        }
        sortedProducts[price].Add(product);
    }

    public void DisplayCart()
    {
        Console.WriteLine("\nShopping Cart (Purchase Order):");
        foreach (var product in purchaseOrder)
        {
            Console.WriteLine($"{product}: Rs.{productPrices[product]:0.00}");
        }
    }

    public void DisplaySortedByPrice()
    {
        Console.WriteLine("\nCart Items Sorted by Price:");
        foreach (var entry in sortedProducts)
        {
            foreach (var product in entry.Value)
            {
                Console.WriteLine($"{product}: ${entry.Key:0.00}");
            }
        }
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var price in productPrices.Values)
        {
            total += price;
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        Console.WriteLine("Shopping Cart System - Enter products and prices. Type 'exit' to finish.");

        while (true)
        {
            Console.Write("\nEnter product name (or 'exit' to finish): ");
            string product = Console.ReadLine().Trim();

            if (product.ToLower() == "exit")
                break;

            Console.Write("Enter price: ");
            if (double.TryParse(Console.ReadLine(), out double price) && price >= 0)
            {
                cart.AddProduct(product, price);
            }
            else
            {
                Console.WriteLine("Invalid price. Please enter a valid number.");
            }
        }
        cart.DisplayCart();
        cart.DisplaySortedByPrice();
        Console.WriteLine($"\nTotal Price: Rs.{cart.GetTotalPrice():0.00}");
    }
}
