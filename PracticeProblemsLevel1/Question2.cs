// Question2.cs
using System;

class Question2
{
    public void CalculateHandshakes()
    {
        // Taking user input for number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Calculating maximum number of handshakes
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Displaying the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {handshakes}");
    }
}
