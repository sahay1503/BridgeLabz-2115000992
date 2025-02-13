public class PairWithSum
{
    public static bool HasPairWithSum(int[] arr, int target)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int num in arr)
        {
            int complement = target - num;

            // Check if the complement exists in the set
            if (seenNumbers.Contains(complement))
            {
                Console.WriteLine($"Pair found: ({num}, {complement})");
                return true;
            }

            // Add current number to set
            seenNumbers.Add(num);
        }

        return false;
    }
}
