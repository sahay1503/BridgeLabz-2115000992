//Class Student 
using System;
using System.Collections.Generic;

// Represents a student who can enroll in multiple courses
class Student
{
    // The name of the student
    public string Name { get; set; }

    // List of courses the student is enrolled in
    public List<Course> Courses { get; set; }

    // Constructor to initialize the student with a name
    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>(); // Initializes an empty list of courses
    }

    // Enrolls the student in a course (if not already enrolled)
    public void EnrollInCourse(Course course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course); // Adds the course to the student's list of enrolled courses
        }
    }

    // Displays all courses the student is currently enrolled in
    public void ViewEnrolledCourses()
    {
        Console.WriteLine($"Student: {Name}");

        // Loop through each course and display its name
        foreach (var course in Courses)
        {
            Console.WriteLine($"Enrolled in: {course.CourseName}");
        }
    }
}
