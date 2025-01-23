using System;

// Creating a class to implement FizzBuzz using a for loop
class Program5
{
    // Function to perform FizzBuzz
    public static string FizzBuzz(int n)
    {
        if (n <= 0)
        {
            return "Invalid input. Please enter a positive integer.";
        }

        string result = "";
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result += "FizzBuzz\n";
            }
            else if (i % 3 == 0)
            {
                result += "Fizz\n";
            }
            else if (i % 5 == 0)
            {
                result += "Buzz\n";
            }
            else
            {
                result += i + "\n";
            }
        }
        return result;
    }
}