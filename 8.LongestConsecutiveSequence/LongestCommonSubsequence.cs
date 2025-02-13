public class LongestConsecutiveSequence
{
    public static int FindLongestConsecutiveSequence(int[] arr)
    {
        if (arr.Length == 0) return 0;

        HashSet<int> numSet = new HashSet<int>(arr);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            // Check if it's the start of a sequence (i.e., num-1 is not present)
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                // Count the length of the consecutive sequence
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}
