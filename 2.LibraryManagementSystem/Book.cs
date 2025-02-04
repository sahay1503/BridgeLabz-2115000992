// Book class to represent library books
class Book
{
    public static string LibraryName = "Central Library"; // Shared across all books
    public readonly string ISBN; // Unique identifier that cannot be changed for ISBN because it is unique for everything.
    public static string Title; // Static variable to store title of the project
    public static string Author; // Static variable to store author of the book

    // Constructor to register a book in Library Management System
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        this.ISBN = isbn;
    }

    // Static method to display library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("\nBook Details:");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("ISBN: " + ISBN);
    }
}