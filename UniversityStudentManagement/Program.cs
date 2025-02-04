using System;
class Program
{
    public static void Main()
    {
        bool exit = false; // Controls the loop, program runs until exit becomes true
        Student newStudent = null; // Initialize to avoid unassigned error

        while (!exit) // Loop runs continuously until the user chooses to exit
        {
            // Display the main menu
            Console.WriteLine("\nWelcome to the University Student Management System");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("What do you want to do?\n 1. Add a Student\n 2. Display Total Students\n 3. Display Student Details\n 4. Update Grade\n 5. Exit");
            Console.WriteLine("-----------------------------------------------------");

            int choice = int.Parse(Console.ReadLine() ?? "");
            // Perform actions based on user's choice
            switch (choice)
            {
                case 1:
                    // Ask user for student details
                    Console.WriteLine("Enter Student Roll Number: ");
                    int rollNumber = int.Parse(Console.ReadLine() ?? "");

                    Console.WriteLine("Enter Student Name: ");
                    string name = Console.ReadLine() ?? "";

                    Console.WriteLine("Enter Student Grade: ");
                    string grade = Console.ReadLine() ?? "";

                    // Create a new Student object with user input
                    newStudent = new Student(rollNumber, name, grade);

                    // Display the student details
                    Console.WriteLine("\nStudent Details:\n");
                    newStudent.DisplayStudentDetails();
                    break;

                case 2:
                    // Display total number of students enrolled
                    Student.DisplayTotalStudents();
                    break;

                case 3:
                    // Display student details if a student has been created
                    if (newStudent != null)
                    {
                        Student.DisplayIfStudent(newStudent);
                    }
                    else
                    {
                        Console.WriteLine("No student has been added yet.");
                    }
                    break;

                case 4:
                    // Update the student's grade if a student exists
                    if (newStudent != null)
                    {
                        Console.WriteLine("Enter new grade: ");
                        string newGrade = Console.ReadLine() ?? "";
                        newStudent.UpdateGrade(newGrade);
                    }
                    else
                    {
                        Console.WriteLine("No student to update.");
                    }
                    break;

                case 5:
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
