using System;
class Program
{
    public static void Main()
    {
        // Creating book objects
        Book book1 = new Book("Ramayana", "Valmiki");
        Book book2 = new Book("Mahabharata", "Ved Vyas");
        Book book3 = new Book("Harry Potter", "J. K. Rowling");

        // Creating library objects
        Library library1 = new Library("City Library");
        Library library2 = new Library("University Library");

        // Adding books to libraries
        library1.AddBook(book1);
        library1.AddBook(book2);
        library2.AddBook(book2);
        library2.AddBook(book3);

        // Displaying books in libraries
        library1.DisplayBooks();
        Console.WriteLine();
        library2.DisplayBooks();
    }
}
