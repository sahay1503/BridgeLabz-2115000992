using System;
public class Program2
{
    public static void PerformDateArithmetic()
    {
        Console.WriteLine("Enter a date (yyyy-MM-dd):");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        DateTime modifiedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2).AddDays(-21);
        Console.WriteLine($"Modified Date: {modifiedDate:yyyy-MM-dd}");
    }
}