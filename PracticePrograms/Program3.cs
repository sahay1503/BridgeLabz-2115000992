// Program3.cs
using System;

namespace PracticePrograms.Programs
{
    class Program3
    {
        public void ConvertDistance()
        {
            // Create a double variable 'kilometers' and assign value 10.8
            double kilometers = 10.8;

            // Convert kilometers to miles using the formula 1 mile = 1.6 km
            double miles = kilometers / 1.6;

            // Display the result
            Console.WriteLine($"The distance {kilometers} km in miles is {miles:F2}");
        }
    }
}
