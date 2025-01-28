// Question4.cs
using System;

class Question4
{
    public void CheckNumberSign()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Checking if the number is positive, negative, or zero
        int result = number > 0 ? 1 : (number < 0 ? -1 : 0);

        // Displaying the result
        Console.WriteLine($"The number {number} is {(result == 1 ? "positive" : (result == -1 ? "negative" : "zero"))}");
    }
}
