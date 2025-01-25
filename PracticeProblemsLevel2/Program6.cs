using System;
class Program6
{
    public string CalculateBMI(double[] heights, double[] weights)
    {
        string result = "";
        for (int i = 0; i < heights.Length; i++)
        {
            double bmi = weights[i] / (heights[i] * heights[i]);
            result += $"BMI for person {i + 1}: {bmi:F2}\n";
        }
        return result;
    }
}