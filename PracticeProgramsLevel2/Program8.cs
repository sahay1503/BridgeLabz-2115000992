using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program8
    {
        public void SampleTrip()
        {
            // Take user inputs for trip details
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the starting city: ");
            string fromCity = Console.ReadLine();
            Console.Write("Enter the via city: ");
            string viaCity = Console.ReadLine();
            Console.Write("Enter the destination city: ");
            string toCity = Console.ReadLine();

            // Take distances and time taken as input
            Console.Write("Enter the distance from starting city to via city (in miles): ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the distance from via city to destination city (in miles): ");
            double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the time taken for the journey (in hours): ");
            double timeTaken = Convert.ToDouble(Console.ReadLine());

            // Calculate total distance and average speed
            double totalDistance = fromToVia + viaToFinalCity;
            double averageSpeed = totalDistance / timeTaken;

            // Display the results
            Console.WriteLine($"{name} traveled from {fromCity} to {toCity} via {viaCity}.\n" +
                              $"The total distance is {totalDistance:F2} miles, and the average speed is {averageSpeed:F2} mph.");
        }
    }
}