using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program11
    {
        public void CalculateSimpleInterest()
        {
            // Take principal, rate, and time as input
            Console.Write("Enter the principal amount: INR ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the rate of interest (in %): ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Calculate simple interest
            double simpleInterest = (principal * rate * time) / 100;

            // Display the result
            Console.WriteLine($"The Simple Interest is INR {simpleInterest:F2} for Principal INR {principal:F2}, Rate of Interest {rate:F2}%, and Time {time} years.");
        }
    }
}