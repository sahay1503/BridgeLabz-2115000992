using System;
public class Program3
{
    public static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}