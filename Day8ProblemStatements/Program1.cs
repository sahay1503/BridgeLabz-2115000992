using System;
public class Program1
{
    public static (int vowels, int consonants) CountVowelsAndConsonants(string str)
    {
        int vowels = 0, consonants = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                    vowels++;
                else
                    consonants++;
            }
        }
        return (vowels, consonants);
    }
}