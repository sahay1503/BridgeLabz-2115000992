using System;
public class Program7
{
    public static string ToggleCase(string str)
    {
        char[] arr = str.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            if (char.IsUpper(arr[i]))
                arr[i] = char.ToLower(arr[i]);
            else if (char.IsLower(arr[i]))
                arr[i] = char.ToUpper(arr[i]);
        }
        return new string(arr);
    }
}