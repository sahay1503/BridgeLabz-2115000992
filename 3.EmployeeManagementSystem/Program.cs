using System;
class Program
{
    public static void Main()
    {
        bool exit = false; // Controls the loop, program runs until exit becomes true

        while (!exit) // Loop runs continuously until the user chooses to exit
        {
            // Display the main menu
            Console.WriteLine("\nWelcome to Employee Management System of Capgemini Technology Services India Limited");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("What do you want to do?\n 1. Add a new Employee and display it\n 2. Total number of Employees\n 3. Exit");
            Console.WriteLine("------------------------------------------------");

            int choice = int.Parse(Console.ReadLine() ?? "");
            // Perform actions based on user's choice
            switch (choice)
            {
                case 1:
                    // Ask user for employee details
                    Console.WriteLine("Enter Employee Name: ");
                    string name = Console.ReadLine() ?? "";

                    Console.WriteLine("Enter Employee ID: ");
                    int id = int.Parse(Console.ReadLine() ?? ""); // Read employee ID

                    Console.WriteLine("Enter Employee Designation: ");
                    string designation = Console.ReadLine() ?? ""; // Read employee designation

                    // Create a new Employee object with user input
                    Employee newEmployee = new Employee(name, id, designation);

                    // Confirm employee creation
                    Console.WriteLine("Employee added successfully!\n");
                    Console.WriteLine("Employee Details:");

                    // Display employee details
                    newEmployee.DisplayEmployeeDetails();
                    break;

                case 2:
                    // Show total number of employees created
                    Employee.DisplayTotalEmployees();
                    break;

                case 3:
                    // Exit the program
                    Console.WriteLine("Exiting the program...");
                    exit = true; // Set exit to true to break out of the loop
                    break;

                default:
                    // Handle incorrect menu choices
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    break;
            }
        }
    }
}
