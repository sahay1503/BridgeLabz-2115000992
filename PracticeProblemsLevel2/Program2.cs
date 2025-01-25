using System;

class Program2
{
    public string FindYoungestAndTallest(string[] friends, int[] ages, double[] heights)
    {
        int youngestIndex = 0;
        int tallestIndex = 0; // Corrected from double to int

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex]) youngestIndex = i;
            if (heights[i] > heights[tallestIndex]) tallestIndex = i;
        }

        return $"The youngest friend is {friends[youngestIndex]}.\nThe tallest friend is {friends[tallestIndex]}.";
    }
}