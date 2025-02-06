//Class University
using System;
using System.Collections.Generic;

// Represents a university that aggregates departments and faculties
class University
{
    // The name of the university
    public string Name { get; set; }

    // List of departments in the university (private to restrict direct access)
    private List<Department> Departments { get; set; }

    // List of faculty members associated with the university (private to restrict direct access)
    private List<Faculty> Faculties { get; set; }

    // Constructor to initialize the university with a name
    public University(string name)
    {
        Name = name;
        Departments = new List<Department>(); // Initializes an empty list of departments
        Faculties = new List<Faculty>(); // Initializes an empty list of faculties
    }

    // Adds a new department to the university
    public void AddDepartment(string departmentName)
    {
        Departments.Add(new Department(departmentName)); // Adds a new department
    }

    // Adds a new faculty member to the university
    public void AddFaculty(Faculty faculty)
    {
        Faculties.Add(faculty); // Adds the faculty to the list
    }

    // Displays the university's structure, including departments and faculties
    public void DisplayUniversity()
    {
        Console.WriteLine($"University: {Name}");

        // Display all departments in the university
        Console.WriteLine("Departments:");
        foreach (var department in Departments)
        {
            department.Display();
        }

        // Display all faculty members in the university
        Console.WriteLine("Faculties:");
        foreach (var faculty in Faculties)
        {
            faculty.Display();
        }
    }
}
