// Program11.cs
using System;

namespace PracticePrograms.Programs
{
    class Program11
    {
        public void BasicCalculator()
        {
            // Take user inputs for two numbers
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Perform arithmetic operations
            double addition = number1 + number2;
            double subtraction = number1 - number2;
            double multiplication = number1 * number2;
            double division = number2 != 0 ? number1 / number2 : double.NaN;

            // Display the results
            Console.WriteLine($"The addition, subtraction, multiplication, and division of {number1} and {number2} are: {addition}, {subtraction}, {multiplication}, and {division:F2} respectively.");
        }
    }
}
