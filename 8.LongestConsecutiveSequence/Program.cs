using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        int longestSequence = LongestConsecutiveSequence.FindLongestConsecutiveSequence(arr);
        Console.WriteLine($"Longest Consecutive Sequence Length: {longestSequence}");
    }
}
