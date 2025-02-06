//class Professor
using System;
// Represents a professor in the university, who teaches courses
class Professor
{
    // The name of the professor
    public string Name { get; set; }

    // The department the professor belongs to
    public string Department { get; set; }

    // Constructor to initialize the professor with a name and department
    public Professor(string name, string department)
    {
        // Set the name of the professor
        Name = name;

        // Set the department the professor belongs to
        Department = department;
    }

    // Displays the professor's details
    public void Display()
    {
        // Print the professor's name and department
        Console.WriteLine($"Professor: {Name}, Department: {Department}");
    }
}
