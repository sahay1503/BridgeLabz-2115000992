using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidLicensePlate(string plate)
    {
        string pattern = @"^[A-Z]{2}\d{4}$";
        return Regex.IsMatch(plate, pattern);
    }

    static void Main()
    {
        string[] testPlates = { "AB1234", "A12345", "XY9876", "abc1234", "Z1234", "CD56789" };

        foreach (var plate in testPlates)
        {
            Console.WriteLine($"'{plate}' is {(IsValidLicensePlate(plate) ? "Valid" : "Invalid")}");
        }
    }
}
