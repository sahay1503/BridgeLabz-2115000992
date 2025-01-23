using System;

// Creating a class to find the youngest and tallest among 3 friends
class Program8
{
    // Function to find the youngest and tallest
    public static string FindYoungestAndTallest(int age1, int age2, int age3, double height1, double height2, double height3)
    {
        // Find the youngest
        int youngestAge = Math.Min(age1, Math.Min(age2, age3));

        // Find the tallest
        double tallestHeight = Math.Max(height1, Math.Max(height2, height3));

        return $"Youngest Age: {youngestAge}\nTallest Height: {tallestHeight} cm";
    }
}