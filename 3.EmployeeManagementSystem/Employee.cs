// Class representing an Employee
public class Employee
{
    // Static variable shared across all instances, representing the company name
    public static string CompanyName = "Tech Solutions Ltd.";

    // Readonly field for Employee ID (cannot be modified after initialization)
    public readonly int Id;

    // Static variable to keep track of the total number of employees
    private static int totalEmployees = 0;

    // Private fields to store the employee's name and designation
    private string Name;
    private string Designation;

    // Constructor to initialize an employee with Name, Id, and Designation
    public Employee(string name, int id, string designation)
    {
        this.Name = name; // Assign the employee's name
        this.Id = id; // Assign the employee's ID
        this.Designation = designation; // Assign the employee's designation
        totalEmployees++; // Increment the total number of employees
    }

    // Static method to display the total number of employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine($"Total Employees: {totalEmployees}");
    }

    // Method to display the details of a specific employee
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Company: {CompanyName}");
        Console.WriteLine($"Employee ID: {Id}");
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Employee Designation: {Designation}");
    }
}
