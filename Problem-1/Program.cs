using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidUsername(string username)
    {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        return Regex.IsMatch(username, pattern);
    }

    static void Main()
    {
        string[] testUsernames = { "user_123", "123user", "us", "Valid_User", "A1_2345678901234", "TooLongUsername123456" };

        foreach (var username in testUsernames)
        {
            Console.WriteLine($"'{username}' is {(IsValidUsername(username) ? "Valid" : "Invalid")}");
        }
    }
}
