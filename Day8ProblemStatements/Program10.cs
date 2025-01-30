using System;
public class Program10
{
    public static string RemoveCharacter(string str, char ch)
    {
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ch)
                result += str[i];
        }
        return result;
    }
}