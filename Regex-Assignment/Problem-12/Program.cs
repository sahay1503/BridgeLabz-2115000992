using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static List<string> ExtractProgrammingLanguages(string text)
    {
        string pattern = @"\b(JavaScript|Java|Python|C\+\+|C#|Go|Ruby|Swift|PHP|Kotlin|Rust|TypeScript|Perl|Scala|R|Dart|Haskell)\b";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        List<string> languages = new List<string>();

        foreach (Match match in matches)
        {
            languages.Add(match.Value);
        }

        return languages;
    }

    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";

        List<string> extractedLanguages = ExtractProgrammingLanguages(text);

        Console.WriteLine("Extracted Programming Languages:");
        Console.WriteLine(string.Join(", ", extractedLanguages));
    }
}
