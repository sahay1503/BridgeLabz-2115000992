using System;

class SumOfDigits
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.Error.WriteLine("Invalid Number.");
            Environment.Exit(0);
        }

        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}
