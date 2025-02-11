using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        StudentRecord studentList = new StudentRecord();
        while (true)
        {
            Console.WriteLine("\n--- Student Record Management System ---");
            Console.WriteLine("1. Add Student at Beginning");
            Console.WriteLine("2. Add Student at End");
            Console.WriteLine("3. Add Student at Specific Position");
            Console.WriteLine("4. Delete Student by Roll Number");
            Console.WriteLine("5. Search Student by Roll Number");
            Console.WriteLine("6. Display All Students");
            Console.WriteLine("7. Update Student Grade");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Roll Number: ");
                    int roll1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name1 = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    char grade1 = Convert.ToChar(Console.ReadLine());
                    studentList.AddAtBeginning(roll1, name1, age1, grade1);
                    break;

                case 2:
                    Console.Write("Enter Roll Number: ");
                    int roll2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name2 = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    char grade2 = Convert.ToChar(Console.ReadLine());
                    studentList.AddAtEnd(roll2, name2, age2, grade2);
                    break;

                case 3:
                    Console.Write("Enter Roll Number: ");
                    int roll3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name3 = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    char grade3 = Convert.ToChar(Console.ReadLine());
                    Console.Write("Enter Position: ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    studentList.AddAtPosition(roll3, name3, age3, grade3, position);
                    break;

                case 4:
                    Console.Write("Enter Roll Number to delete: ");
                    int rollDel = Convert.ToInt32(Console.ReadLine());
                    studentList.DeleteByRollNumber(rollDel);
                    break;

                case 5:
                    Console.Write("Enter Roll Number to search: ");
                    int rollSearch = Convert.ToInt32(Console.ReadLine());
                    studentList.SearchByRollNumber(rollSearch);
                    break;

                case 6:
                    studentList.DisplayAll();
                    break;

                case 7:
                    Console.Write("Enter Roll Number to update grade: ");
                    int rollUpdate = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter New Grade: ");
                    char newGrade = Convert.ToChar(Console.ReadLine());
                    studentList.UpdateGrade(rollUpdate, newGrade);
                    break;

                case 8:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}