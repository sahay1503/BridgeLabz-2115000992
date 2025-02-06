//Class Book
using System;
class Book
{
    // Stores the book's title (can only be set inside this class)
    public string Title { get; private set; }

    // Stores the author's name (can only be set inside this class)
    public string Author { get; private set; }

    // Constructor to initialize the book with a title and author
    public Book(string Title, string Author)
    {
        this.Title = Title;
        this.Author = Author;
    }

    // Displays book details
    public void DisplayBook()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}");
    }
}
