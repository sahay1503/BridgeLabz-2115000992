using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _1.EmployeeManagementSystem
{
    //class FullTimeEmployee that inherits Employee and IDepartment
    public class FullTimeEmployee :Employee, IDepartment
    {
        //variable to store the name of department employee works in
        string department;
        //Constructor for Full Time Employee
        public FullTimeEmployee(int id, string name, double salary) : base(id, name, salary) { }
        //Full Time employees have fixed salary
        public override double CalculateSalary()
        {
            return BaseSalary;
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
