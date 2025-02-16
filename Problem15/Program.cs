using System;

class Program
{
    static void Main()
    {
        int[] nums = { 3, 4, -1, 1 }; 
        int target = 4;

        int missingPositive = FindFirstMissingPositive(nums);
        Console.WriteLine($"First missing positive integer: {missingPositive}");

        Array.Sort(nums); // Sort for Binary Search
        int targetIndex = BinarySearch(nums, target);
        Console.WriteLine(targetIndex != -1 ? $"Target {target} found at index: {targetIndex}" : $"Target {target} not found.");
    }

    // Linear Search to find the first missing positive integer
    static int FindFirstMissingPositive(int[] nums)
    {
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
            {
                (nums[nums[i] - 1], nums[i]) = (nums[i], nums[nums[i] - 1]);
            }
        }

        // Identify the first missing positive integer
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
                return i + 1;
        }

        return n + 1; 
    }

    // Binary Search to find the index of target number
    static int BinarySearch(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; 
    }
}
