using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class WordCounter
{
    static void Main()
    {
        string filePath = "sample.txt";

        try
        {
            Dictionary<string, int> wordCounts = CountWordsInFile(filePath);

            if (wordCounts.Count == 0)
            {
                Console.WriteLine("No words found in the file.");
                return;
            }

            Console.WriteLine($"\nTotal unique words: {wordCounts.Count}");
            Console.WriteLine("\nTop 5 Most Frequently Occurring Words:");

            foreach (var word in wordCounts.OrderByDescending(w => w.Value).Take(5))
            {
                Console.WriteLine($"{word.Key}: {word.Value} times");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
    }

    static Dictionary<string, int> CountWordsInFile(string filePath)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: The specified file does not exist.");
            return wordCount;
        }

        using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Normalize line: remove punctuation and split into words
                string[] words = Regex.Replace(line, @"[^\w\s]", "").ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                }
            }
        }

        return wordCount;
    }
}
