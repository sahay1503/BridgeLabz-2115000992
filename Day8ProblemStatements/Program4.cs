using System;
public class Program4
{
    public static string RemoveDuplicates(string str)
    {
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (result.IndexOf(c) == -1)
                result += c;
        }
        return result;
    }
}