// Create SumOfDigit Class to compute the sum of all digits of a number
using System;

class SumOfDigits
{
    static void Main(string[] args)
    {
        // Get input value for number
        Console.WriteLine("Enter a number:");
        int originalNumber = Convert.ToInt32(Console.ReadLine());

        // Print the sum
        Console.WriteLine("The sum of digits of number " + originalNumber + " is " + SumOfDigit(originalNumber));
    }
    public static int SumOfDigit(int originalNumber)
    {
        // Define variable number and sum initialized to zero
        int number = originalNumber;
        int sum = 0;

        // Run while loop to access each digit of number
        while (number != 0)
        {
            // Use number % 10 to find each digit of number from last
            int digit = number % 10;

            // add each digit to sum
            sum += digit;

            // Remove last digit from number essentially get the quotient
            number = number / 10;
        }
        return sum;

    }
}
