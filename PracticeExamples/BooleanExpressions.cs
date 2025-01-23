using System;

class BooleanExpressions
{
    public static void Main()
    {
        // Is the given number even or odd
        // ask user to input a number
        Console.WriteLine("\nEnter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Show if the number is even or odd
        Console.WriteLine("Is the number Even? " + (number % 2 == 0));
        // Show if the number is positive or negative
        Console.WriteLine("Is the number Positive? " + (number > 0));
        // Show if the number is zero or non-zero
        Console.WriteLine("Is the number Zero? " + (number == 0));
    }
}