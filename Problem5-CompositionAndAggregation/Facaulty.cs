//Class Faculty
using System;
// Represents a faculty member in a university, independent of departments
class Faculty
{
    // The name of the faculty member
    public string Name { get; set; }

    // The area of specialization of the faculty member
    public string Specialization { get; set; }

    // Constructor to initialize the faculty member with a name and specialization
    public Faculty(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
    }

    // Displays the faculty member's name and their area of specialization
    public void Display()
    {
        Console.WriteLine($"Faculty: {Name}, Specialization: {Specialization}");
    }
}
