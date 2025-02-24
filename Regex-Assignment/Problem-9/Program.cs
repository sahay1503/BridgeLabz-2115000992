using System;
using System.Text.RegularExpressions;

class Program
{
    static string CensorBadWords(string text, string[] badWords)
    {
        string pattern = @"\b(" + string.Join("|", badWords) + @")\b";
        return Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
    }

    static void Main()
    {
        string input = "This is a damn bad example with some stupid words.";
        string[] badWords = { "damn", "stupid" };

        string output = CensorBadWords(input, badWords);

        Console.WriteLine("Censored Output:");
        Console.WriteLine(output);
    }
}
