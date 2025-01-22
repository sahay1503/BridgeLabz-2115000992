// Program8.cs
using System;

namespace PracticePrograms.Programs
{
    class Program8
    {
        public void ConvertDistanceWithInput()
        {
            // Take user input for kilometers
            Console.Write("Enter the distance in kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            // Convert kilometers to miles
            double miles = kilometers / 1.6;

            // Display the result
            Console.WriteLine($"The total miles is {miles:F2} mile for the given {kilometers} km");
        }
    }
}