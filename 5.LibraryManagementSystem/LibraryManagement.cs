class LibraryManagement
{
    private Book head = null;
    private Book tail = null;
    private int bookCount = 0;

    // Add a book at the beginning
    public void AddAtBeginning(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        bookCount++;
        Console.WriteLine("Book added at the beginning.");
    }

    // Add a book at the end
    public void AddAtEnd(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        bookCount++;
        Console.WriteLine("Book added at the end.");
    }

    // Add a book at a specific position
    public void AddAtPosition(string title, string author, string genre, int bookID, bool isAvailable, int position)
    {
        if (position <= 0 || position > bookCount + 1)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(title, author, genre, bookID, isAvailable);
            return;
        }

        if (position == bookCount + 1)
        {
            AddAtEnd(title, author, genre, bookID, isAvailable);
            return;
        }

        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        Book temp = head;
        int count = 1;

        while (count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        newBook.Next = temp.Next;
        newBook.Prev = temp;
        if (temp.Next != null)
            temp.Next.Prev = newBook;
        temp.Next = newBook;

        bookCount++;
        Console.WriteLine($"Book added at position {position}.");
    }

    // Remove a book by Book ID
    public void RemoveBook(int bookID)
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Book temp = head;
        while (temp != null && temp.BookID != bookID)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (temp == head)
            head = temp.Next;
        if (temp == tail)
            tail = temp.Prev;
        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;
        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;

        bookCount--;
        Console.WriteLine($"Book {bookID} removed.");
    }

    // Search for a book by Title
    public void SearchByTitle(string title)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                PrintBook(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    // Search for a book by Author
    public void SearchByAuthor(string author)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                PrintBook(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    // Update book availability status
    public void UpdateAvailability(int bookID, bool isAvailable)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.IsAvailable = isAvailable;
                Console.WriteLine($"Book {bookID} availability updated.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    // Display all books in forward order
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("Library Books (Forward):");
        Book temp = head;
        while (temp != null)
        {
            PrintBook(temp);
            temp = temp.Next;
        }
    }

    // Display all books in reverse order
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("Library Books (Reverse):");
        Book temp = tail;
        while (temp != null)
        {
            PrintBook(temp);
            temp = temp.Prev;
        }
    }

    // Count the total number of books
    public void CountBooks()
    {
        Console.WriteLine($"Total Books in Library: {bookCount}");
    }

    // Helper function to print book details
    private void PrintBook(Book book)
    {
        Console.WriteLine($"ID: {book.BookID}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {(book.IsAvailable ? "Yes" : "No")}");
    }
}