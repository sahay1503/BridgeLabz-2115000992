class Book {
    public string Title { get; private set; }
    public string Author{ get; private set;}

    public Book(string Title,string Author) {
        this.Title = Title;
        this.Author = Author;
    }
    public void DisplayBook() {
        Console.WriteLine($"Book: {Title}, Author: {Author}");
    }

}