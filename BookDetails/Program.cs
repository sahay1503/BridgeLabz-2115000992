using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create Book object for the book The Alchemist by Paulo Coelho
        Book book1 = new Book("The Alchemist", "Paulo Coelho", 15.99);
        // Create Book object for the book The Atomic Habits by James Clear
        Book book2 = new Book("Atomic Habits", "James Clear", 20.50);

        // Display book details
        Console.WriteLine("----Book 1----");
        book1.DisplayDetails();
        Console.WriteLine("\n----Book 2----");
        book2.DisplayDetails();
    }
}
