using System;

// Creating class HarshadChecker to determine if a number is a Harshad number.
class Program3
{
    public static string IsHarshad(int number)
    {
        int sum = 0, originalNumber = number;

        // Loop to calculate the sum of digits
        while (originalNumber != 0)
        {
            sum += originalNumber % 10; // Add the last digit to sum
            originalNumber /= 10; // Remove the last digit
        }

        // Check divisibility
        if (number % sum == 0)
        {
            return $"{number} is a Harshad Number.";
        }
        else
        {
            return $"{number} is not a Harshad Number.";
        }
    }
}