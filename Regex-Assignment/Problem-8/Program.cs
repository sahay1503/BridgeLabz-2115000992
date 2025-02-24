using System;
using System.Text.RegularExpressions;

class Program
{
    static string ReplaceMultipleSpaces(string text)
    {
        return Regex.Replace(text, @"\s+", " ");
    }

    static void Main()
    {
        string input = "This    is  an   example   with    multiple    spaces.";
        string output = ReplaceMultipleSpaces(input);

        Console.WriteLine("Modified String:");
        Console.WriteLine(output);
    }
}
