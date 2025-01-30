using System;
public class Program8
{
    public static string CompareStrings(string str1, string str2)
    {
        int minLength = str1.Length < str2.Length ? str1.Length : str2.Length;
        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i]) return $"{str1} comes before {str2}";
            if (str1[i] > str2[i]) return $"{str2} comes before {str1}";
        }
        return str1.Length < str2.Length ? $"{str1} comes before {str2}" : $"{str2} comes before {str1}";
    }
}