// Question6.cs
using System;

class Question6
{
    public void SumOfNaturalNumbers()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Calculating sum of natural numbers
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        // Displaying the result
        Console.WriteLine($"The sum of {number} natural numbers is {sum}");
    }
}
