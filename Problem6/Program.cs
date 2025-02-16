using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "file.txt"; 
        string wordToFind = "C#"; 

        try
        {
            int wordCount = CountWordOccurrences(filePath, wordToFind);
            Console.WriteLine($"The word \"{wordToFind}\" appears {wordCount} times in the file.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
        }
    }

    static int CountWordOccurrences(string filePath, string word)
    {
        int count = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Count occurrences of the word in each line
                count += CountOccurrencesInLine(line, word);
            }
        }
        return count;
    }

    static int CountOccurrencesInLine(string line, string word)
    {
        int count = 0, index = 0;
        while ((index = line.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            index += word.Length; // Move past the word
        }
        return count;
    }
}
