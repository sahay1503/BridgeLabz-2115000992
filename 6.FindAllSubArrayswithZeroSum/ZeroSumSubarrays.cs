
public class ZeroSumSubarrays
{
    public static void FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        int sum = 0;

        // Store initial condition (sum = 0 at index -1)
        sumMap[0] = new List<int> { -1 };

        Console.WriteLine("Zero Sum Subarrays:");

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            // If sum already exists in map, we found zero-sum subarrays
            if (sumMap.ContainsKey(sum))
            {
                foreach (int start in sumMap[sum])
                {
                    Console.WriteLine($"Subarray found from index {start + 1} to {i}");
                }
            }

            // Add current sum to map
            if (!sumMap.ContainsKey(sum))
            {
                sumMap[sum] = new List<int>();
            }

            sumMap[sum].Add(i);
        }
    }
}
