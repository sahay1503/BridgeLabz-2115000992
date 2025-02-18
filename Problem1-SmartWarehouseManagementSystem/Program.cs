using System;
using System.Collections.Generic;

// Abstract base class for warehouse items
public abstract class WarehouseItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayDetails(); // Abstract method to display item details
}

// Concrete class for Electronics
public class Electronics : WarehouseItem
{
    public string Brand { get; set; }

    public Electronics(string name, double price, string brand)
        : base(name, price)
    {
        Brand = brand;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Electronics - Name: {Name}, Price: {Price}, Brand: {Brand}");
    }
}

// Concrete class for Groceries
public class Groceries : WarehouseItem
{
    public string ExpiryDate { get; set; }

    public Groceries(string name, double price, string expiryDate)
        : base(name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Groceries - Name: {Name}, Price: {Price}, Expiry: {ExpiryDate}");
    }
}

// Concrete class for Furniture
public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, double price, string material)
        : base(name, price)
    {
        Material = material;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Furniture - Name: {Name}, Price: {Price}, Material: {Material}");
    }
}

// Generic class to store items of type WarehouseItem or derived types
public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayAllItems()
    {
        foreach (var item in items)
        {
            item.DisplayDetails(); // Calls the overridden method in each class
        }
    }
}

// Main Program with User Input using while loop and switch case
public class Program
{
    public static void Main()
    {
        Storage<WarehouseItem> warehouse = new Storage<WarehouseItem>();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nSmart Warehouse Management System");
            Console.WriteLine("1. Add Electronics");
            Console.WriteLine("2. Add Groceries");
            Console.WriteLine("3. Add Furniture");
            Console.WriteLine("4. Display All Items");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Electronics Name: ");
                    string electronicsName = Console.ReadLine();
                    Console.Write("Enter Price: ");
                    double electronicsPrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Brand: ");
                    string electronicsBrand = Console.ReadLine();
                    Electronics electronics = new Electronics(electronicsName, electronicsPrice, electronicsBrand);
                    warehouse.AddItem(electronics);
                    break;

                case "2":
                    Console.Write("Enter Groceries Name: ");
                    string groceriesName = Console.ReadLine();
                    Console.Write("Enter Price: ");
                    double groceriesPrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Expiry Date: ");
                    string expiryDate = Console.ReadLine();
                    Groceries groceries = new Groceries(groceriesName, groceriesPrice, expiryDate);
                    warehouse.AddItem(groceries);
                    break;

                case "3":
                    Console.Write("Enter Furniture Name: ");
                    string furnitureName = Console.ReadLine();
                    Console.Write("Enter Price: ");
                    double furniturePrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Material: ");
                    string material = Console.ReadLine();
                    Furniture furniture = new Furniture(furnitureName, furniturePrice, material);
                    warehouse.AddItem(furniture);
                    break;

                case "4":
                    Console.WriteLine("\nDisplaying All Items in the Warehouse:");
                    warehouse.DisplayAllItems();
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Exiting the program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
