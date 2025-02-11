class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool IsAvailable;
    public Book Next;
    public Book Prev;

    public Book(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}