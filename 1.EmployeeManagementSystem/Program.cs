using System;
using System.Collections;
namespace _1.EmployeeManagementSystem
{
    public class Program {
        static void Main(string[] args)
        {
            // Creating a list of employees for both types
            List<Employee> employees = new List<Employee>
            {
                new FullTimeEmployee(101, "Vidya Sagar Singh", 60000),
                new PartTimeEmployee(102, "Swapnil Gupta", 20, 120)
            };

            // Assign departments to employees
            ((IDepartment)employees[0]).AssignDepartment("HR");
            ((IDepartment)employees[1]).AssignDepartment("IT");

            // Display details of each employee
            foreach (var emp in employees)
            {
                emp.DisplayDetails();
                Console.WriteLine(((IDepartment)emp).GetDepartmentDetails());
            }
        }
    }
}