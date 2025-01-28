
using System;

class Question 12
{
    public void CalculateHandshakes()
    {
        // Taking user input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Calculating the maximum number of handshakes using combination formula
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Displaying the result
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {handshakes}.");
    }
}
