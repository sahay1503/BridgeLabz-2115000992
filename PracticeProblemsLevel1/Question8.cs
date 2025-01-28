// Question8.cs
using System;

class Question8
{
    public void FindRemainderAndQuotient()
    {
        // Taking user input for two numbers
        Console.Write("Enter the dividend: ");
        int dividend = int.Parse(Console.ReadLine());
        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        // Calculating quotient and remainder
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        // Displaying the results
        Console.WriteLine($"The quotient is {quotient} and the remainder is {remainder}");
    }
}
