using System;
using System.Collections.Generic;

// Abstract base class for product categories
abstract class ProductCategory
{
    public string CategoryName { get; set; }
}

// Specific product categories
class BookCategory : ProductCategory
{
    public BookCategory() { CategoryName = "Books"; }
}

class ClothingCategory : ProductCategory
{
    public ClothingCategory() { CategoryName = "Clothing"; }
}

// Generic Product class with a type constraint
class Product<T> where T : ProductCategory
{
    public string Name { get; set; }
    public double Price { get; set; }
    public T Category { get; set; }

    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}, Category: {Category.CategoryName}, Price: Rs.{Price:F2}");
    }
}

// Manages product catalog separately
class ProductCatalog
{
    private List<object> catalog = new List<object>();

    public void AddProduct<C>(string name, double price, C category) where C : ProductCategory
    {
        var product = new Product<C>(name, price, category);
        catalog.Add(product);
        Console.WriteLine($"{name} added to the catalog successfully!");
    }

    public void DisplayProducts()
    {
        if (catalog.Count == 0)
        {
            Console.WriteLine("No products in the catalog.");
            return;
        }

        Console.WriteLine("\nProduct Catalog:");
        foreach (var item in catalog)
        {
            switch (item)
            {
                case Product<BookCategory> book:
                    book.DisplayInfo();
                    break;
                case Product<ClothingCategory> clothing:
                    clothing.DisplayInfo();
                    break;
            }
        }
    }

    public List<object> GetCatalog()
    {
        return catalog;
    }
}

// Handles discounts
class DiscountManager
{
    public static void ApplyDiscount<C>(Product<C> product, double percentage) where C : ProductCategory
    {
        if (percentage < 0 || percentage > 100)
        {
            Console.WriteLine("Invalid discount percentage! Enter a value between 0-100.");
            return;
        }

        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine($"Discount applied! New price of {product.Name}: Rs.{product.Price:F2}");
    }
}

class Program
{
    static void Main()
    {
        ProductCatalog productCatalog = new ProductCatalog();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Online Marketplace Menu ---");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Add a Clothing Item");
            Console.WriteLine("3. Display Product Catalog");
            Console.WriteLine("4. Apply Discount to a Product");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddProductToCatalog(productCatalog, new BookCategory());
                    break;
                case "2":
                    AddProductToCatalog(productCatalog, new ClothingCategory());
                    break;
                case "3":
                    productCatalog.DisplayProducts();
                    break;
                case "4":
                    ApplyDiscountToProduct(productCatalog);
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Exiting Marketplace. Thank you!");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    break;
            }
        }
    }

    // Method to handle adding a product
    static void AddProductToCatalog<C>(ProductCatalog catalog, C category) where C : ProductCategory
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        double price;
        while (true)
        {
            Console.Write("Enter product price: ");
            if (double.TryParse(Console.ReadLine(), out price) && price > 0)
                break;
            Console.WriteLine("Invalid price! Please enter a positive number.");
        }

        catalog.AddProduct(name, price, category);
    }

    // Method to apply a discount
    static void ApplyDiscountToProduct(ProductCatalog catalog)
    {
        var productList = catalog.GetCatalog();
        if (productList.Count == 0)
        {
            Console.WriteLine("No products available to apply a discount.");
            return;
        }

        Console.WriteLine("Available Products:");
        for (int i = 0; i < productList.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            switch (productList[i])
            {
                case Product<BookCategory> book:
                    book.DisplayInfo();
                    break;
                case Product<ClothingCategory> clothing:
                    clothing.DisplayInfo();
                    break;
            }
        }

        int index;
        while (true)
        {
            Console.Write("Enter the product number to apply a discount: ");
            if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= productList.Count)
                break;
            Console.WriteLine("Invalid input! Please enter a valid product number.");
        }

        double discount;
        while (true)
        {
            Console.Write("Enter discount percentage (0-100): ");
            if (double.TryParse(Console.ReadLine(), out discount) && discount >= 0 && discount <= 100)
                break;
            Console.WriteLine("Invalid percentage! Enter a value between 0-100.");
        }

        switch (productList[index - 1])
        {
            case Product<BookCategory> book:
                DiscountManager.ApplyDiscount(book, discount);
                break;
            case Product<ClothingCategory> clothing:
                DiscountManager.ApplyDiscount(clothing, discount);
                break;
        }
    }
}