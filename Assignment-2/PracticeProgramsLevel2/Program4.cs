using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program4
    {
        public void CelsiusToFahrenheit()
        {
            // Take temperature in Celsius as input
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Convert Celsius to Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Display the result
            Console.WriteLine($"The {celsius:F2} Celsius is {fahrenheit:F2} Fahrenheit.");
        }
    }
}