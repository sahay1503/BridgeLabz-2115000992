using System;
class Program
{
    public static void Main()
    {
        bool exit = false; // Controls the loop, program runs until exit becomes true
        Product newProduct = null; // Initialize the variable to avoid the unassigned error

        while (!exit) // Loop runs continuously until the user chooses to exit
        {
            // Display the main menu
            Console.WriteLine("\nWelcome to the Shopping Cart System");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("What do you want to do?\n 1. Add a Product to the cart\n 2. Update Discount\n 3. Display Product Details\n 4. Exit");
            Console.WriteLine("------------------------------------------------");

            int choice = int.Parse(Console.ReadLine() ?? "");
            // Perform actions based on user's choice
            switch (choice)
            {
                case 1:
                    // Ask user for product details
                    Console.WriteLine("Enter Product ID: ");
                    int productID = int.Parse(Console.ReadLine() ?? "");

                    Console.WriteLine("Enter Product Name: ");
                    string productName = Console.ReadLine() ?? "";

                    Console.WriteLine("Enter Product Price: ");
                    double price = double.Parse(Console.ReadLine() ?? "");

                    Console.WriteLine("Enter Product Quantity: ");
                    int quantity = int.Parse(Console.ReadLine() ?? "");

                    // Create a new Product object with user input
                    newProduct = new Product(productID, productName, price, quantity);

                    // Display the product details

                    Console.WriteLine("\nProduct Details:");
                    newProduct.DisplayProductDetails();
                    break;

                case 2:
                    // Update the discount for all products
                    Console.WriteLine("Enter new discount percentage: ");
                    double newDiscount = double.Parse(Console.ReadLine() ?? "");

                    // Update the discount
                    Product.UpdateDiscount(newDiscount);
                    break;

                case 3:
                    // Check if a product has been created before displaying details
                    if (newProduct != null)
                    {
                        // Display details of the product
                        Product.DisplayIfProduct(newProduct);
                    }
                    else
                    {
                        Console.WriteLine("No product has been added yet.");
                    }
                    break;

                case 4:
                    // Exit the program
                    Console.WriteLine("Exiting the program...");
                    exit = true; // Set exit to true to break out of the loop
                    break;

                default:
                    // Handle incorrect menu choices
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    break;
            }
        }
    }
}
