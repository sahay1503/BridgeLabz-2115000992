//class Student
using System;
using System.Collections.Generic;
// Represents a student, who is enrolled in multiple courses
class Student
{
    // The name of the student
    public string Name { get; set; }

    // List of courses the student is enrolled in
    public List<Course> Courses { get; set; }

    // Constructor to initialize the student with a name
    public Student(string name)
    {
        // Set the student's name
        Name = name;

        // Initializes an empty list of courses the student is enrolled in
        Courses = new List<Course>();
    }

    // Enroll the student in a course
    public void EnrollCourse(Course course)
    {
        // Add the course to the student's list of courses
        Courses.Add(course);

        // Enroll the student in the course as well
        course.EnrollStudent(this);
    }

    // Displays the courses the student is enrolled in
    public void DisplayCourses()
    {
        // Print the student's name
        Console.WriteLine($"Student: {Name}");

        // Loop through each course the student is enrolled in and display its name
        foreach (var course in Courses)
        {
            Console.WriteLine($"Enrolled in: {course.Name}");
        }
    }
}
