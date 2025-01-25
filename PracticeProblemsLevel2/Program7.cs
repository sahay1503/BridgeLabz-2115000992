using System;
class Program7
{
    public string CalculateBMIWith2DArray(double[][] personData)
    {
        string result = "";
        for (int i = 0; i < personData.Length; i++)
        {
            double bmi = personData[i][1] / (personData[i][0] * personData[i][0]);
            result += $"BMI for person {i + 1}: {bmi:F2}\n";
        }
        return result;
    }
}