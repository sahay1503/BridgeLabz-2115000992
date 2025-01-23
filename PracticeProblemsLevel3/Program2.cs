using System;

// Creating class DigitCounter to count the number of digits in an integer.
class Program2
{
    public static string CountDigits(int number)
    {
        // Initialize count to zero
        int count = 0;

        // Loop to count digits
        while (number != 0)
        {
            number /= 10; // Remove the last digit
            count++; // Increment the count
        }

        return $"The number has {count} digit(s).";
    }
}