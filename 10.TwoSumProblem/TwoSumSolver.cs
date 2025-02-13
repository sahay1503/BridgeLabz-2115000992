public class TwoSumSolver
{
    // Function to find two indices that sum up to the target
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            // If complement exists in the dictionary, return indices
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            // Store the number with its index
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }

        return new int[] { -1, -1 }; // Return -1 if no valid pair found
    }

    // Function to print an array
    public static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}