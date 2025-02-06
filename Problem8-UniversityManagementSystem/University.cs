//class University
using System;
using System.Collections.Generic;

// Represents a university that manages professors, students, and courses
class University
{
    // The name of the university
    public string Name { get; set; }

    // List of courses offered by the university
    public List<Course> Courses { get; set; }

    // List of professors working at the university
    public List<Professor> Professors { get; set; }

    // List of students enrolled at the university
    public List<Student> Students { get; set; }

    // Constructor to initialize the university with a name
    public University(string name)
    {
        // Set the name of the university
        Name = name;

        // Initializes empty lists for courses, professors, and students
        Courses = new List<Course>();
        Professors = new List<Professor>();
        Students = new List<Student>();
    }

    // Adds a new course to the university
    public void AddCourse(Course course)
    {
        // Add the course to the list of courses
        Courses.Add(course);
    }

    // Adds a new professor to the university
    public void AddProfessor(Professor professor)
    {
        // Add the professor to the list of professors
        Professors.Add(professor);
    }

    // Adds a new student to the university
    public void AddStudent(Student student)
    {
        // Add the student to the list of students
        Students.Add(student);
    }

    // Displays the entire university information, including courses, professors, and students
    public void DisplayUniversity()
    {
        // Print the university name
        Console.WriteLine($"University: {Name}");

        // Display all courses offered by the university
        Console.WriteLine("Courses:");
        foreach (var course in Courses)
        {
            course.DisplayCourse();
        }

        // Display all professors working at the university
        Console.WriteLine("Professors:");
        foreach (var professor in Professors)
        {
            professor.Display();
        }

        // Display all students enrolled at the university
        Console.WriteLine("Students:");
        foreach (var student in Students)
        {
            student.DisplayCourses();
        }
    }
}
