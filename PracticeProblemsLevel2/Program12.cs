using System;

// Creating a class to find all multiples of a number below 100
class Program12
{
    // Function to find multiples of a number below 100
    public static string FindMultiples(int number)
    {
        if (number <= 0)
        {
            return "Invalid input. Number must be a positive integer.";
        }

        string multiples = "Multiples of " + number + " below 100: ";
        for (int i = 1; i < 100; i++)
        {
            if (i % number == 0)
            {
                multiples += i + " ";
            }
        }

        return multiples.Trim();
    }
}