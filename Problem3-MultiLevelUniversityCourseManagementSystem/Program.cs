using System;
using System.Collections.Generic;

// Abstract base class for different course types
abstract class CourseType
{
    public string CourseName { get; set; }
    public abstract void DisplayEvaluationMethod();
}

// Specific course types
class ExamCourse : CourseType
{
    public ExamCourse(string courseName) { CourseName = courseName; }
    public override void DisplayEvaluationMethod()
    {
        Console.WriteLine($"{CourseName} is evaluated through Exams.");
    }
}

class AssignmentCourse : CourseType
{
    public AssignmentCourse(string courseName) { CourseName = courseName; }
    public override void DisplayEvaluationMethod()
    {
        Console.WriteLine($"{CourseName} is evaluated through Assignments.");
    }
}

// Generic class to manage university courses
class Course<T> where T : CourseType
{
    public string Department { get; set; }
    public T CourseDetails { get; set; }

    public Course(string department, T courseDetails)
    {
        Department = department;
        CourseDetails = courseDetails;
    }

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Department: {Department}");
        CourseDetails.DisplayEvaluationMethod();
    }
}

// University course management system
class UniversityCourseManager
{
    private List<object> courses = new List<object>();

    public void AddCourse<T>(Course<T> course) where T : CourseType
    {
        courses.Add(course);
        Console.WriteLine($"{course.CourseDetails.CourseName} added successfully to {course.Department} department.");
    }

    public void DisplayAllCourses()
    {
        if (courses.Count == 0)
        {
            Console.WriteLine("No courses available.");
            return;
        }

        Console.WriteLine("\nUniversity Course Catalog:");
        foreach (var item in courses)
        {
            if (item is Course<ExamCourse> examCourse)
                examCourse.DisplayCourseInfo();
            else if (item is Course<AssignmentCourse> assignmentCourse)
                assignmentCourse.DisplayCourseInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        UniversityCourseManager manager = new UniversityCourseManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- University Course Management Menu ---");
            Console.WriteLine("1. Add an Exam-Based Course");
            Console.WriteLine("2. Add an Assignment-Based Course");
            Console.WriteLine("3. Display All Courses");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddExamCourse(manager);
                    break;
                case "2":
                    AddAssignmentCourse(manager);
                    break;
                case "3":
                    manager.DisplayAllCourses();
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Exiting Course Management System. Thank you!");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    break;
            }
        }
    }

    static void AddExamCourse(UniversityCourseManager manager)
    {
        Console.Write("Enter the Department: ");
        string department = Console.ReadLine();

        Console.Write("Enter the Course Name: ");
        string courseName = Console.ReadLine();

        Course<ExamCourse> newCourse = new Course<ExamCourse>(department, new ExamCourse(courseName));
        manager.AddCourse(newCourse);
    }

    static void AddAssignmentCourse(UniversityCourseManager manager)
    {
        Console.Write("Enter the Department: ");
        string department = Console.ReadLine();

        Console.Write("Enter the Course Name: ");
        string courseName = Console.ReadLine();

        Course<AssignmentCourse> newCourse = new Course<AssignmentCourse>(department, new AssignmentCourse(courseName));
        manager.AddCourse(newCourse);
    }
}
