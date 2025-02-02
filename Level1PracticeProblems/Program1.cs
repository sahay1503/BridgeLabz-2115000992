using System;
class Program1
{
    public static void print()
    {
        Console.WriteLine("Enter the Title :");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the Author :");
        string author = Console.ReadLine();
        Console.WriteLine("Enter the Price :");
        int price = Convert.ToInt32(Console.ReadLine());
        Book book1 = new Book();
        Console.WriteLine("Enter the Title Manually:");
        book1.SetTitle(Console.ReadLine());
        Console.WriteLine("Enter the Author Manually:");
        book1.SetAuthor(Console.ReadLine());
        Console.WriteLine("Enter the Price Manually:");
        book1.SetPrice(Convert.ToInt32(Console.ReadLine()));
        Book book2 = new Book(title, author, price);
        book1.info();
        book2.info();

    }
}
class Book
{
    private string title;
    private string author;
    private int price;
    public Book()
    {
        Console.WriteLine("Call from Default constructor");
    }
    public Book(string title, string author, int price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }
    public void SetAuthor(string author)
    {
        this.author = author;
    }
    public void SetPrice(int price)
    {
        this.price = price;
    }
    public void info()
    {
        Console.WriteLine("_____________----------");
        Console.WriteLine("Title :" + this.title);
        Console.WriteLine("Author :" + this.author);
        Console.WriteLine("Price :" + this.price);
    }
}

