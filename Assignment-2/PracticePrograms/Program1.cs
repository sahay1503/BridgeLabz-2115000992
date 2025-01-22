using System;

namespace PracticePrograms.Programs
{
    class Program1
    {
        public void CalculateAge()
        {
            // Create an integer variable 'birthYear' and assign value 2000
            int birthYear = 2000;

            // Create an integer variable 'currentYear' and assign value 2024
            int currentYear = 2024;

            // Calculate age by subtracting birth year from current year
            int age = currentYear - birthYear;

            // Display the result
            Console.WriteLine($"Harry's age in {currentYear} is {age}");
        }
    }
}
