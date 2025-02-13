public class CircularTour
{
    public static int FindStartingPump(int[] petrol, int[] distance)
    {
        int start = 0, surplus = 0, deficit = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            surplus += petrol[i] - distance[i];

            // If surplus is negative, reset starting point
            if (surplus < 0)
            {
                start = i + 1;
                deficit += surplus;
                surplus = 0;
            }
        }

        // If total petrol is sufficient to cover the total distance
        return (surplus + deficit >= 0) ? start : -1;
    }
}
