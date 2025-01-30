using System;
public class Program6 {
    public static int CountSubstringOccurrences(string str, string sub)
    {
        int count = 0;
        for (int i = 0; i <= str.Length - sub.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < sub.Length; j++)
            {
                if (str[i + j] != sub[j])
                {
                    match = false;
                    break;
                }
            }
            if (match) count++;
        }
        return count;
    }
}