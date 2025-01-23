using System;

// Creating class ArmstrongChecker to determine if a number is an Armstrong number.
class Program1
{
    public static string IsArmstrong(int number)
    {
        // Define variables to calculate sum of cubes of digits
        int originalNumber = number, sum = 0;

        // Loop to calculate the sum of cubes of digits
        while (originalNumber != 0)
        {
            int remainder = originalNumber % 10; // Get the last digit
            sum += remainder * remainder * remainder; // Add cube of the digit to the sum
            originalNumber /= 10; // Remove the last digit
        }

        // Check if the calculated sum matches the original number
        if (sum == number)
        {
            return $"{number} is an Armstrong Number.";
        }
        else
        {
            return $"{number} is not an Armstrong Number.";
        }
    }
}