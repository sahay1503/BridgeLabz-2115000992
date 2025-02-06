//class Course
using System;
using System.Collections.Generic;
// Represents a course in the university, associated with students and a professor
class Course
{
    // The name of the course
    public string Name { get; set; }

    // The professor assigned to the course
    public Professor AssignedProfessor { get; private set; }

    // List of students enrolled in the course
    public List<Student> EnrolledStudents { get; set; }

    // Constructor to initialize the course with a name
    public Course(string name)
    {
        // Set the name of the course
        Name = name;

        // Initializes an empty list of enrolled students
        EnrolledStudents = new List<Student>();
    }

    // Assign a professor to the course
    public void AssignProfessor(Professor professor)
    {
        // Set the assigned professor for the course
        AssignedProfessor = professor;
    }

    // Enroll a student in the course
    public void EnrollStudent(Student student)
    {
        // Add the student to the list of enrolled students
        EnrolledStudents.Add(student);
    }

    // Displays the course details, including the professor and enrolled students
    public void DisplayCourse()
    {
        // Print the name of the course
        Console.WriteLine($"Course: {Name}");

        // Print the professor's name (if assigned) or "None" if no professor is assigned
        Console.WriteLine($"Professor: {(AssignedProfessor != null ? AssignedProfessor.Name : "None")}");

        // Print the list of enrolled students
        Console.WriteLine("Enrolled Students:");
        foreach (var student in EnrolledStudents)
        {
            // Display each student's name
            Console.WriteLine($"- {student.Name}");
        }
    }
}
