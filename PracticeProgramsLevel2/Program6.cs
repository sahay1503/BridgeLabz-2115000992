using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program6
    {
        public void CalculateTotalIncome()
        {
            // Take salary as input
            Console.Write("Enter the salary: INR ");
            double salary = Convert.ToDouble(Console.ReadLine());

            // Take bonus as input
            Console.Write("Enter the bonus: INR ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            // Calculate total income
            double totalIncome = salary + bonus;

            // Display the result
            Console.WriteLine($"The salary is INR {salary:F2} and bonus is INR {bonus:F2}. Hence, Total Income is INR {totalIncome:F2}.");
        }
    }
}