using System;
public class Book
{
    // Private field for title
    private string title;
    // Private field for author
    private string author;
    // Private field for price
    private double price;

    // Constructor for calling Class Book
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Details:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: Rs." + price);
    }
}
