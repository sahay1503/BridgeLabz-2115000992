using System;
public class Program9
{
    public static char FindMostFrequentCharacter(string str)
    {
        int[] freq = new int[256];
        for (int i = 0; i < str.Length; i++)
            freq[str[i]]++;
        int maxCount = 0;
        char mostFrequent = ' ';
        for (int i = 0; i < str.Length; i++)
        {
            if (freq[str[i]] > maxCount)
            {
                maxCount = freq[str[i]];
                mostFrequent = str[i];
            }
        }
        return mostFrequent;
    }
}