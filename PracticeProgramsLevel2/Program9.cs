using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program9
    {
        public void CalculateAthleteRounds()
        {
            // Take three sides of the triangular park as input
            Console.Write("Enter the first side of the park (in meters): ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second side of the park (in meters): ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third side of the park (in meters): ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Calculate the perimeter
            double perimeter = side1 + side2 + side3;

            // Calculate the number of rounds needed to complete 5 km
            double distanceToRun = 5000; // 5 km in meters
            double rounds = distanceToRun / perimeter;

            // Display the result
            Console.WriteLine($"The total number of rounds the athlete will run is {Math.Ceiling(rounds)} to complete 5 km.");
        }
    }
}
