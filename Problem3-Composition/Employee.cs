//class Employee
using System;

// Represents an employee who is part of a department
class Employee
{
    // The name of the employee
    public string Name { get; set; }

    // The position or job title of the employee
    public string Position { get; set; }

    // Constructor to initialize an employee with a name and position
    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    // Displays employee details
    public void Display()
    {
        Console.WriteLine($"Employee: {Name}, Position: {Position}");
    }
}
