//Class Course
using System;
using System.Collections.Generic;

// Represents a course that students can enroll in
class Course
{
    // The name of the course
    public string CourseName { get; set; }

    // List of students currently enrolled in the course
    public List<Student> EnrolledStudents { get; set; }

    // Constructor to initialize the course with a name
    public Course(string courseName)
    {
        CourseName = courseName;
        EnrolledStudents = new List<Student>(); // Initializes an empty list of enrolled students
    }

    // Enrolls a student in the course (if they are not already enrolled)
    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student);
            student.EnrollInCourse(this); // Notifies the student that they have enrolled in the course
        }
    }

    // Displays all students enrolled in the course
    public void DisplayEnrolledStudents()
    {
        Console.WriteLine($"Course: {CourseName}");

        // Loop through each enrolled student and display their name
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine($"Student: {student.Name}");
        }
    }
}
