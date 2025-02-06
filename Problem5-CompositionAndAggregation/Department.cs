//Class Department
using System;
// Represents a department within a university
class Department
{
    // The name of the department
    public string Name { get; set; }

    // Constructor to initialize the department with a name
    public Department(string name)
    {
        Name = name;
    }

    // Displays the department's name
    public void Display()
    {
        Console.WriteLine($"Department: {Name}");
    }
}
