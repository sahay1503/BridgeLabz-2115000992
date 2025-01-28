// Question11.cs
using System;

class Question11
{
    public void CalculateTrigonometricFunctions()
    {
        // Taking user input for an angle in degrees
        Console.Write("Enter an angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        // Converting angle to radians
        double radians = Math.PI * angle / 180.0;

        // Calculating trigonometric functions
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Displaying the results
        Console.WriteLine($"Sine: {sine:F4}, Cosine: {cosine:F4}, Tangent: {tangent:F4}");
    }
}
