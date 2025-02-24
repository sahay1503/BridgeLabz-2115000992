using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static HashSet<string> FindRepeatingWords(string text)
    {
        string pattern = @"\b(\w+)\s+\1\b";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        HashSet<string> repeatingWords = new HashSet<string>();

        foreach (Match match in matches)
        {
            repeatingWords.Add(match.Groups[1].Value);
        }

        return repeatingWords;
    }

    static void Main()
    {
        string input = "This is is a repeated repeated word test.";

        HashSet<string> repeatedWords = FindRepeatingWords(input);

        Console.WriteLine("Repeating Words:");
        Console.WriteLine(string.Join(", ", repeatedWords));
    }
}
