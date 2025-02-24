using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidSSN(string ssn)
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        return Regex.IsMatch(ssn, pattern);
    }

    static void Main()
    {
        string[] testSSNs = { "123-45-6789", "987-65-4321", "123456789", "123-456-789", "12-34-5678" };

        foreach (var ssn in testSSNs)
        {
            Console.WriteLine($"'{ssn}' is {(IsValidSSN(ssn) ? "Valid ✅" : "Invalid ❌")}");
        }
    }
}
