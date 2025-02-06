//class Library
using System;
using System.Collections.Generic;
class Library
{
    // Stores the library name (can only be set inside this class)
    public string nameOfLibrary { get; private set; }

    // List to keep track of books in the library
    public List<Book> Books;

    // Constructor to initialize the library with a name
    public Library(string name)
    {
        this.nameOfLibrary = name;
        Books = new List<Book>(); // Creates an empty list of books
    }

    // Adds a book to the library
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"{book.Title} by {book.Author} added to the library.");
    }

    // Displays all books in the library
    public void DisplayBooks()
    {
        Console.WriteLine($"Library: {nameOfLibrary}");

        // Go through each book and display its details
        foreach (var book in Books)
        {
            book.DisplayBook();
        }
    }
}
