using System;

// Creating a class to calculate the power of a number
class Program10
{
    // Function to calculate the power of a number
    public static string CalculatePower(int number, int power)
    {
        if (power < 0)
        {
            return "Invalid input. Power must be a non-negative integer.";
        }

        int result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        return $"{number} raised to the power of {power} is {result}.";
    }
}