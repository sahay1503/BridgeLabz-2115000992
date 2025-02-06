//Class School
using System;
using System.Collections.Generic;

// Represents a school that aggregates a list of students
class School
{
    // The name of the school
    public string SchoolName { get; set; }

    // List of students enrolled in the school
    public List<Student> Students { get; set; }

    // Constructor to initialize the school with a name
    public School(string schoolName)
    {
        SchoolName = schoolName;
        Students = new List<Student>(); // Initializes an empty list of students
    }

    // Adds a student to the school (if they are not already added)
    public void AddStudent(Student student)
    {
        if (!Students.Contains(student))
        {
            Students.Add(student); // Adds the student to the list
        }
    }

    // Displays all students enrolled in the school
    public void DisplayStudents()
    {
        Console.WriteLine($"School: {SchoolName}");

        // Loop through each student and display their name
        foreach (var student in Students)
        {
            Console.WriteLine($"Student: {student.Name}");
        }
    }
}
