class Library {
    public string nameOfLibrary{ get; private set; }
    public List<Book> Books;

    public Library(string name) {
        this.nameOfLibrary = name;
        Books = new List<Book>();
    }
    public void AddBook(Book book) { 
        Books.Add(book);
        Console.WriteLine(book.Title+" written by "+book.Author+" is added in the Library");
    }
    public void DisplayBooks()
    {
        Console.WriteLine($"Library: {nameOfLibrary}");
        
        foreach (var book in Books)
        {
            book.DisplayBook();
        }
    }

}