using System;
using System.Collections.Generic;


class Program
{
    public static void Main()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] result = SlidingWindowMaximum.MaxSlidingWindow(nums, k);

        Console.WriteLine("Sliding Window Maximum:");
        Console.WriteLine(string.Join(" ", result));
    }
}
