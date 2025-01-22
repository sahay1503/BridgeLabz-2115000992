using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program5
    {
        public void FahrenheitToCelsius()
        {
            // Take temperature in Fahrenheit as input
            Console.Write("Enter the temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Convert Fahrenheit to Celsius
            double celsius = (fahrenheit - 32) * 5 / 9;

            // Display the result
            Console.WriteLine($"The {fahrenheit:F2} Fahrenheit is {celsius:F2} Celsius.");
        }
    }
}