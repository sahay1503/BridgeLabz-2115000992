using System;
using System.Collections.Generic;

namespace ECommercePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of products (polymorphism in action)
            List<Product> products = new List<Product>
            {
                new Electronics(101, "Laptop", 50000),
                new Clothing(102, "T-Shirt", 1200),
                new Groceries(103, "Rice", 500)
            };

            // Display details and calculate final price
            foreach (var product in products)
            {
                product.DisplayDetails();

                double tax = 0;
                if (product is ITaxable taxableProduct)
                {
                    tax = taxableProduct.CalculateTax();
                    Console.WriteLine(taxableProduct.GetTaxDetails()); // Show tax details
                }

                // Calculate final price (Price + Tax - Discount)
                double finalPrice = product.Price + tax - product.CalculateDiscount();
                Console.WriteLine($"Final Price: {finalPrice:C}\n");
            }
        }
    }
}
