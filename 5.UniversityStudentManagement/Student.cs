public class Student
{
    // Static variable shared across all instances, representing the university name
    public static string UniversityName = "XYZ University";

    // Readonly field for RollNumber (cannot be modified after initialization)
    public readonly int RollNumber;

    // Instance fields to store the student's name, grade, and other details
    private string Name;
    private string Grade;

    // Static variable to keep track of the total number of students enrolled
    private static int totalStudents = 0;

    // Constructor to initialize student details: Name, RollNumber, and Grade
    public Student(int rollNumber, string name, string grade)
    {
        this.RollNumber = rollNumber; // Assign the unique roll number
        this.Name = name; // Assign the student's name
        this.Grade = grade; // Assign the student's grade
        totalStudents++; // Increment the total number of students enrolled
    }

    // Static method to display the total number of students enrolled
    public static void DisplayTotalStudents()
    {
        Console.WriteLine($"Total Students Enrolled: {totalStudents}");
    }

    // Method to display student details including university name and grade
    public void DisplayStudentDetails()
    {
        Console.WriteLine($"University: {UniversityName}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Grade: {Grade}");
    }

    // Method to validate whether an object is an instance of the Student class
    public static void DisplayIfStudent(object obj)
    {
        if (obj is Student student)
        {
            student.DisplayStudentDetails();
        }
        else
        {
            Console.WriteLine("This is not a valid Student object.");
        }
    }

    // Method to update grade for a student (this method can only be used for valid students)
    public void UpdateGrade(string newGrade)
    {
        this.Grade = newGrade;
        Console.WriteLine($"Grade updated to {Grade} for {Name}");
    }
}