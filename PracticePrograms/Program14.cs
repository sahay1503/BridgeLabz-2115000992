// Program14.cs
using System;

namespace PracticePrograms.Programs
{
    class Program14
    {
        public void DistanceConversion()
        {
            // Take user input for distance in feet
            Console.Write("Enter the distance in feet: ");
            double distanceFeet = Convert.ToDouble(Console.ReadLine());

            // Convert distance to yards and miles
            double distanceYards = distanceFeet / 3;
            double distanceMiles = distanceYards / 1760;

            // Display the result
            Console.WriteLine($"The distance in feet is {distanceFeet}, which is {distanceYards:F2} yards and {distanceMiles:F2} miles.");
        }
    }
}
