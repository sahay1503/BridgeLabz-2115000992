using System;

class LogicalOperators
{
    public static void Main()
    {
        // Take input for a number
        Console.WriteLine("\nEnter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Display the number characteristics
        Console.WriteLine("Is number Even & greater or equal to 10 ? " + (number % 2 == 0 && number >= 10));

        Console.WriteLine("Is the number divisible by 3 or 4? " + (number % 3 == 0 || number % 4 == 0));

        Console.WriteLine("Is the number not zero and divisible by 3? " + (!(number == 0) && number % 3 == 0));


    }
}