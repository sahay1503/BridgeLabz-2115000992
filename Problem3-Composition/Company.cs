//Class Company
using System;
using System.Collections.Generic;

// Represents a company that consists of multiple departments and employees
class Company
{
    // The name of the company
    public string Name { get; set; }

    // List of departments within the company (private to restrict direct access)
    private List<Department> Departments { get; set; }

    // Constructor to initialize the company with a name
    public Company(string name)
    {
        Name = name;
        Departments = new List<Department>(); // Initializes an empty department list
    }

    // Adds a new department to the company
    public void AddDepartment(string departmentName)
    {
        Departments.Add(new Department(departmentName));
    }

    // Adds an employee to a specific department (if it exists)
    public void AddEmployeeToDepartment(string departmentName, string employeeName, string position)
    {
        var department = Departments.Find(d => d.Name == departmentName);

        if (department != null)
        {
            department.AddEmployee(employeeName, position);
        }
        else
        {
            Console.WriteLine("Department not found.");
        }
    }

    // Displays the entire company structure, including all departments and employees
    public void DisplayCompanyStructure()
    {
        Console.WriteLine($"Company: {Name}");

        // Loop through each department and display its employees
        foreach (var department in Departments)
        {
            department.DisplayEmployees();
        }
    }
}
