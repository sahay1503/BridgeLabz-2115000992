using System;
public class Program11
{
    public static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        int[] freq = new int[256];
        for (int i = 0; i < str1.Length; i++)
        {
            freq[str1[i]]++;
            freq[str2[i]]--;
        }

        for (int i = 0; i < 256; i++)
        {
            if (freq[i] != 0)
                return false;
        }
        return true;
    }

}