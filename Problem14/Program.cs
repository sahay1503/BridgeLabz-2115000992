using System;

class Program
{
    static void Main()
    {
        int[] sortedArray = { 2, 4, 4, 4, 6, 8, 10 };
        int target = 4; 

        int firstIndex = FindFirstOccurrence(sortedArray, target);
        int lastIndex = FindLastOccurrence(sortedArray, target);

        if (firstIndex != -1)
            Console.WriteLine($"First occurrence of {target} is at index: {firstIndex}");
        else
            Console.WriteLine($"{target} not found in the array.");

        if (lastIndex != -1)
            Console.WriteLine($"Last occurrence of {target} is at index: {lastIndex}");
    }

    static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid; 
                right = mid - 1; 
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }

    static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid; 
                left = mid + 1; 
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }
}
