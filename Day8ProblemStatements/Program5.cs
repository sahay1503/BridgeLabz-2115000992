using System;
public class Program5 { 
    public static string FindLongestWord(string sentence)
    {
        string longest = "", current = "";
        for (int i = 0; i <= sentence.Length; i++)
        {
            if (i < sentence.Length && sentence[i] != ' ')
                current += sentence[i];
            else
            {
                if (current.Length > longest.Length)
                    longest = current;
                current = "";
            }
        }
        return longest;
    }
}