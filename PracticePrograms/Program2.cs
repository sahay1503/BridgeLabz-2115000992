// Program2.cs
using System;

namespace PracticePrograms.Programs
{
    class Program2
    {
        public void CalculateAverage()
        {
            // Create integer variables for marks and assign values
            int maths = 94, physics = 95, chemistry = 96;

            // Calculate average of the marks
            double average = (maths + physics + chemistry) / 3.0;

            // Display the result
            Console.WriteLine($"Sam’s average mark in PCM is {average:F2}");
        }
    }
}