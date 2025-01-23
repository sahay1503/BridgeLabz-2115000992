using System;

// Creating class AbundantChecker to determine if a number is an Abundant number.
class Program4
{
    public static string IsAbundant(int number)
    {
        int sum = 0;

        // Loop to find divisors and calculate their sum
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i; // Add divisor to sum
            }
        }

        // Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            return $"{number} is an Abundant Number.";
        }
        else
        {
            return $"{number} is not an Abundant Number.";
        }
    }
}