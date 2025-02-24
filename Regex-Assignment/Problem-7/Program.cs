using System;
using System.Text.RegularExpressions;

class Program
{
    static void ExtractLinks(string text)
    {
        string pattern = @"\bhttps?://[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(/\S*)?\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org for more info. Also, check https://sub.domain.net/path/page.html.";

        Console.WriteLine("Extracted Links:");
        ExtractLinks(text);
    }
}
