// Creating Class with name Program11  to find the sum until the user enters 0 or a negative number using while loop and break statement.
using System;
// Class to calculate the sum of numbers until the user enters 0 or a negative number
class Program11
{
    public void SumUntilZeroOrNegative()
    {
        double total = 0; // Initializing the total sum variable

        // Prompting the user to input numbers
        Console.WriteLine("Enter numbers to sum (stop with 0 or negative number):");

        // Using an infinite while loop to sum the numbers
        while (true)
        {
            double userInput = Convert.ToDouble(Console.ReadLine()); // Reading user input

            // Checking if the input is 0 or negative
            if (userInput <= 0)
            {
                break; // Exiting the loop
            }

            total += userInput; // Adding the input to the total sum
        }

        // Displaying the total sum
        Console.WriteLine("The total sum is: " + total);
    }
}