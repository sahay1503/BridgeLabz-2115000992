// Question7.cs
using System;

class Question7
{
    public void FindSmallestAndLargest()
    {
        // Taking user input for three numbers
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        // Finding smallest and largest numbers
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));

        // Displaying the results
        Console.WriteLine($"The smallest number is {smallest}");
        Console.WriteLine($"The largest number is {largest}");
    }
}
