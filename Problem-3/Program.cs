using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidHexColor(string color)
    {
        string pattern = @"^#([A-Fa-f0-9]{6})$";
        return Regex.IsMatch(color, pattern);
    }

    static void Main()
    {
        string[] testColors = { "#FFA500", "#ff4500", "#123", "#ABCDEF", "#123456", "#GGGGGG", "#12AB" };

        foreach (var color in testColors)
        {
            Console.WriteLine($"'{color}' is {(IsValidHexColor(color) ? "Valid" : "Invalid")}");
        }
    }
}
