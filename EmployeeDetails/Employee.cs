using System;
public class Employee
{
    // Private field for name
    private string name;
    // Private field for id
    private int id;
    // Private field for salary
    private double salary;
    // Constructor for calling class Employee 
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: Rs." + salary);
    }
}
