using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 3, 20, 4, 1, 0 }; 

        int peakIndex = FindPeakElement(arr);
        Console.WriteLine($"A peak element is at index: {peakIndex}, value: {arr[peakIndex]}");
    }

    static int FindPeakElement(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] < arr[mid + 1])
                left = mid + 1; 
            else
                right = mid; 
        }

        return left; 
    }
}
