using System;

// Creating a class to calculate BMI
class Program7
{
    // Function to calculate BMI
    public static string CalculateBMI(double weight, double heightCm)
    {
        if (weight <= 0 || heightCm <= 0)
        {
            return "Invalid input. Weight and height must be positive numbers.";
        }

        // Convert height from cm to meters
        double heightMeters = heightCm / 100.0;

        // Calculate BMI
        double bmi = weight / (heightMeters * heightMeters);

        // Determine BMI status
        string status;
        if (bmi <= 18.4)
        {
            status = "Underweight";
        }
        else if (bmi <= 24.9)
        {
            status = "Normal";
        }
        else if (bmi <= 39.9)
        {
            status = "Overweight";
        }
        else
        {
            status = "Obese";
        }

        return $"BMI: {bmi:F2}\nStatus: {status}";
    }
}