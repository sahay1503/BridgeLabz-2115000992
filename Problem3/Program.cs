using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] words = { "Hello", " ", "World", "!", " Welcome", " to", " C#." };

        string result = ConcatenateStrings(words);
        Console.WriteLine("Concatenated String: " + result);
    }

    static string ConcatenateStrings(string[] strings)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string str in strings)
        {
            sb.Append(str);
        }

        return sb.ToString();
    }
}
