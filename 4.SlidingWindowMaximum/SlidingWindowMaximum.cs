
public class SlidingWindowMaximum
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0) return new int[0];

        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            // Remove elements that are out of the current window
            if (deque.Count > 0 && deque.First.Value < i - k + 1)
            {
                deque.RemoveFirst();
            }

            // Remove elements from the back of the deque that are smaller than the current element
            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
            {
                deque.RemoveLast();
            }

            // Add current element index to the deque
            deque.AddLast(i);

            // The maximum element is at the front of the deque, add to result once window is full
            if (i >= k - 1)
            {
                result.Add(nums[deque.First.Value]);
            }
        }

        return result.ToArray();
    }
}