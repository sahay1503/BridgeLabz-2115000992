// Program7.cs
using System;

namespace PracticePrograms.Programs
{
    class Program7
    {
        public void EarthVolume()
        {
            // Define radius of earth in km and conversion factor to miles
            double radiusKilometers = 6378;
            double kilometersToMiles = 0.621371;

            // Calculate volume in cubic kilometers and miles
            double volumeKilometers = (4.0 / 3) * Math.PI * Math.Pow(radiusKilometers, 3);
            double volumeMiles = volumeKilometers * Math.Pow(kilometersToMiles, 3);

            // Display the result
            Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKilometers:F2} and cubic miles is {volumeMiles:F2}");
        }
    }
}