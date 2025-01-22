using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program12
    {
        public void PoundsToKilograms()
        {
            // Take weight in pounds as input
            Console.Write("Enter the weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            // Convert pounds to kilograms
            double kilograms = pounds / 2.2;

            // Display the result
            Console.WriteLine($"The weight of the person in pounds is {pounds:F2} and in kilograms is {kilograms:F2}.");
        }
    }
}
