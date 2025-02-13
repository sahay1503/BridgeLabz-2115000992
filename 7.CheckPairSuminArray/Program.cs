using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        int[] arr = { 10, 15, 3, 7 };
        int target = 17;

        if (!PairWithSum.HasPairWithSum(arr, target))
        {
            Console.WriteLine("No pair found.");
        }
    }
}
