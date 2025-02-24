using System;
using System.Text.RegularExpressions;

class Program
{
    static void ExtractCapitalizedWords(string text)
    {
        string pattern = @"\b[A-Z][a-z]*\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.Write(match.Value + " ");
        }
    }

    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        Console.WriteLine("Extracted Capitalized Words:");
        ExtractCapitalizedWords(text);
    }
}
