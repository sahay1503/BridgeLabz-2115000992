using System;

class AverageAge
{
    static void Main(string[] args)
    {
        int[] ages = { 18, 19, 20, 21, 22 }; // Array of ages
        int sum = 0;

        foreach (int age in ages)
        {
            sum += age;
        }

        double average = (double)sum / ages.Length;

        Console.WriteLine("The average age is: " + average);
    }
}
