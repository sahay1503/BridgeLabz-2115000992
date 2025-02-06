//Class Department
using System;
using System.Collections.Generic;

// Represents a department within a company that contains employees
class Department
{
    // The name of the department
    public string Name { get; set; }

    // List of employees in this department (private to restrict direct modification)
    private List<Employee> Employees { get; set; }

    // Constructor to initialize a department with a name
    public Department(string name)
    {
        Name = name;
        Employees = new List<Employee>(); // Initializes an empty employee list
    }

    // Adds a new employee to the department
    public void AddEmployee(string name, string position)
    {
        Employees.Add(new Employee(name, position));
    }

    // Displays all employees in the department
    public void DisplayEmployees()
    {
        Console.WriteLine($"Department: {Name}");

        // Loop through each employee and display their details
        foreach (var employee in Employees)
        {
            employee.Display();
        }
    }
}
