using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Create Employee object for JAmit Yadav
        Employee emp1 = new Employee("Amit Yadav", 101, 55000);
        // Create Employee object for Nishant Chauhan
        Employee emp2 = new Employee("Nishant Chauhan", 102, 62000);

        // Display employee details
        Console.WriteLine("----Employee 1----");
        emp1.DisplayDetails();
        Console.WriteLine("\n----Employee 2----");
        emp2.DisplayDetails();
    }
}
