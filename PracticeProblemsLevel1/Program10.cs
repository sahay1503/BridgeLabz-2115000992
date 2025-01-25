using System;
// Class to perform FizzBuzz
class Program10
{
    public static string GenerateFizzBuzz(int number)
    {
        if (number <= 0)
        {
            return "Invalid input. Enter a positive integer.";
        }
        string[] results = new string[number + 1];
        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString();
            }
        }
        string output = "";
        for (int i = 0; i <= number; i++)
        {
            output += $"Position {i} = {results[i]}\n";
        }
        return output;
    }
}