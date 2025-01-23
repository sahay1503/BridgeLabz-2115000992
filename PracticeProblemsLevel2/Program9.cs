using System;

// Creating a class to find the greatest factor of a number
class Program9
{
    // Function to find the greatest factor
    public static string FindGreatestFactor(int number)
    {
        if (number <= 1)
        {
            return "Invalid input. Number must be greater than 1.";
        }

        int greatestFactor = 1;
        for (int i = number - 1; i > 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        return $"Greatest Factor of {number} (other than itself): {greatestFactor}";
    }
}