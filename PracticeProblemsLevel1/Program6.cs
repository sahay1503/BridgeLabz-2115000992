using System;

// Class to calculate mean height
class Program6
{
    public static string CalculateMean(double[] heights)
    {
        double sum = 0.0;
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }
        double mean = sum / heights.Length;
        return $"Mean height of the football team is {mean:F2}";
    }
}
