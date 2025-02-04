using System;
public class Program
{
    public static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            // Display the main menu
            Console.WriteLine("\nWelcome to Library Management System");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("What do you want to do?\n 1. Add a new Book\n 2. Display Library Name\n 3. Exit");
            Console.WriteLine("------------------------------------------------");

            int choice = int.Parse(Console.ReadLine() ?? "");
            // Perform actions based on user's choice
            switch (choice)
            {
                case 1:
                    // Ask user for book details
                    Console.WriteLine("Enter Book Title: ");
                    string title = Console.ReadLine() ?? "";

                    Console.WriteLine("Enter Book Author: ");
                    string author = Console.ReadLine() ?? "";

                    Console.WriteLine("Enter Book ISBN: ");
                    string isbn = Console.ReadLine() ?? "";

                    // Create a new Book object
                    Book newBook = new Book(title, author, isbn);

                    // Display the book details
                    newBook.DisplayBookDetails();
                    break;

                case 2:
                    // Display the library name
                    Book.DisplayLibraryName();
                    break;

                case 3:
                    // Exit the program
                    Console.WriteLine("Exiting the program...");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    break;
            }
        }
    }
}