// Program10.cs
using System;

namespace PracticePrograms.Programs
{
    class Program10
    {
        public void HeightConverter()
        {
            // Take user input for height in centimeters
            Console.Write("Enter your height in centimeters: ");
            double heightCm = Convert.ToDouble(Console.ReadLine());

            // Convert height to feet and inches
            double heightInches = heightCm / 2.54;
            int feet = (int)(heightInches / 12);
            double inches = heightInches % 12;

            // Display the result
            Console.WriteLine($"Your Height in cm is {heightCm:F2} while in feet is {feet} and inches is {inches:F2}");
        }
    }
}
