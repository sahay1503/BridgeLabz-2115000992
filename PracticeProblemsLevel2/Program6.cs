using System;

// Creating a class to implement FizzBuzz using a while loop
class Program6
{
    // Function to perform FizzBuzz
    public static string FizzBuzz(int n)
    {
        if (n <= 0)
        {
            return "Invalid input. Please enter a positive integer.";
        }

        string result = "";
        int i = 1;
        while (i <= n)
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
            i++;
        }
        return result;
    }
}