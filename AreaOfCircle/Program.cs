using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Create Circle object of radius 5.5
        Circle circle1 = new Circle(5.5);
        // Create Circle object of radius 7.2
        Circle circle2 = new Circle(7.2);

        // Display circle details
        Console.WriteLine("----Circle 1----");
        circle1.DisplayDetails();
        Console.WriteLine("\n----Circle 2----");
        circle2.DisplayDetails();
    }
}
