using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.EmployeeManagementSystem
{
    public class PartTimeEmployee : Employee, IDepartment
    {
        private double hoursWorked;
        private double hourlyRate;
        private string department;

        // Constructor initializes part-time employee with hourly rate and worked hours
        public PartTimeEmployee(int id, string name, double hourlyRate, double hoursWorked)
            : base(id, name, 0) // Base salary is not applicable for part-time employees
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }
        public override double CalculateSalary()
        {
            return hoursWorked * hourlyRate;
        }
        //Providing implementation for AssignDepartment Method that is made inside IDepartment interface
        public void AssignDepartment(string dept)
        {
            department = dept;
        }
        //Providing implementation for GetDepartmentDetails Method that is made inside IDepartment interface
        public string GetDepartmentDetails() 
        { 
            return $"Employee {Name} works in {department} department.";
        }

    }
}
