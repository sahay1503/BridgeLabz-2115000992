using System;

class Program
{
    static void Main()
    {
        string[] sentences =
        {
            "The quick brown fox jumps over the lazy dog.",
            "C# is a powerful programming language.",
            "Linear search is simple but not always efficient.",
            "Searching for a word in a list is a common task."
        };

        string wordToFind = "search"; // 

        string result = FindFirstSentenceWithWord(sentences, wordToFind);

        if (result != null)
            Console.WriteLine($"First sentence containing \"{wordToFind}\":\n{result}");
        else
            Console.WriteLine($"No sentence found containing \"{wordToFind}\".");
    }

    static string FindFirstSentenceWithWord(string[] sentences, string word)
    {
        foreach (string sentence in sentences)
        {
            if (sentence.IndexOf(word, StringComparison.OrdinalIgnoreCase) != -1)
                return sentence; 
        }
        return null; 
    }
}
