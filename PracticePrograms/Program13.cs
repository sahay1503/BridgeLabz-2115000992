// Program13.cs
using System;

namespace PracticePrograms.Programs
{
    class Program13
    {
        public void SquareSide()
        {
            // Take user input for the perimeter of the square
            Console.Write("Enter the perimeter of the square: ");
            double perimeter = Convert.ToDouble(Console.ReadLine());

            // Calculate the side length
            double side = perimeter / 4;

            // Display the result
            Console.WriteLine($"The length of the side is {side:F2} whose perimeter is {perimeter}.");
        }
    }
}