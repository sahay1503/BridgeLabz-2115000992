using System;
// Class to calculate to find the multiplication table of a number entered by the user from 6 to 9.
class Program18
{
    public static void MultiplicationTable()
    {
        // Prompting the user to input a number
        Console.Write("Enter a number to generate its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nMultiplication table of {number} from 6 to 9:\n");

        // Using a for loop to generate and print the multiplication table
        for (int i = 6; i <= 9; i++)
        {
            // Printing the result in the required format
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
