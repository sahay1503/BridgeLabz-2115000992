using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.EmployeeManagementSystem
{
    public abstract class Employee
    {
        //private fields to store employee Details like employeeId, name and baseSalary
        private int employeeId;
        private string name;
        private double baseSalary;
        // Public property for Employee ID (read-only)
        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
            private set
            {
                employeeId = value;
            }
        }
        // Public property for Name (read-only)
        public string Name 
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        // Public property for Base Salary (read-only)
        public double BaseSalary
        {
            get
            {
                return baseSalary;
            }
            private set 
            { 
                baseSalary = value;
            }
        }

        //Constructor to initialize an employee
        public Employee(int id, string name, double salary)
        {
            employeeId = id;
            Name = name;
            BaseSalary = salary;
        }

        //Method to calculate salary
        public abstract double CalculateSalary();

        //Method to Display details of the Employee
        public virtual void DisplayDetails() {
            Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Base Salary: {BaseSalary:C}, Total Salary: {CalculateSalary():C}");
        }





    }
}
