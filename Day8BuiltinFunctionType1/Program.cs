using System;

class Program
{
    static void Main()
    {
        // Problem 1: Time Zones and DateTimeOffset
        Console.WriteLine("Problem 1: Time Zones and DateTimeOffset");
        Program1.DisplayTimeZones();
        // Problem 2: Date Arithmetic
        Console.WriteLine("\nProblem 2: Date Arithmetic");
        Program2.PerformDateArithmetic();
        // Problem 3: Date Formatting
        Console.WriteLine("\nProblem 3: Date Formatting");
        Program3.FormatCurrentDate();
        // Problem 4: Date Comparison
        Console.WriteLine("\nProblem 4: Date Comparison");
        Program4.CompareDates();
    }
}
