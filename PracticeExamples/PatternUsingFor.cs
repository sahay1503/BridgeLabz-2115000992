// Write the program to print the star pattern using for loop
using System;

class Counter
{
    static void Main(string[] args)
    {
        //Take input number of lines you want
        Console.WriteLine("Enter the number of lines of star pattern you want: ");
        int number = Convert.ToInt32(Console.ReadLine());
        // Print the counter

        for (int i = 0; i <= number; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();// to move in next line
        }
    }
}
