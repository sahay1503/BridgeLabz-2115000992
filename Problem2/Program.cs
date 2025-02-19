using System;
using System.Collections.Generic;

class FrequencyCounter
{
    static Dictionary<string, int> CountFrequency(List<string> items)
    {
        Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

        foreach (string item in items)
        {
            if (frequencyMap.ContainsKey(item))
            {
                frequencyMap[item]++;
            }
            else
            {
                frequencyMap[item] = 1;
            }
        }

        return frequencyMap;
    }

    static void Main()
    {
        List<string> items = new List<string> { "apple", "banana", "apple", "orange" };

        Dictionary<string, int> frequency = CountFrequency(items);

        Console.WriteLine("Frequency of elements:");
        foreach (var pair in frequency)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
