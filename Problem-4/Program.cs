using System;
using System.Text.RegularExpressions;

class Program
{
    static void ExtractEmails(string text)
    {
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org. Also, reach out to sales@business.net!";

        Console.WriteLine("Extracted Email Addresses:");
        ExtractEmails(text);
    }
}
