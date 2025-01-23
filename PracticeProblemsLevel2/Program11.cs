using System;

// Creating a class to find all factors of a number
class Program11
{
    // Function to find all factors of a number
    public static string FindFactors(int number)
    {
        if (number <= 0)
        {
            return "Invalid input. Number must be a positive integer.";
        }

        string factors = "Factors: ";
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors += i + " ";
            }
        }

        return factors.Trim();
    }
}