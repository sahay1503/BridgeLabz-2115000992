using System;

public class Program2
{
    public static string ReverseString(string str)
    {
        char[] arr = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = str[str.Length - 1 - i];
        }
        return new string(arr);
    }

}