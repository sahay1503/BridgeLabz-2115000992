using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program1
    {
        public void CalculateQuotientAndRemainder()
        {
            // Take two numbers as input
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Calculate quotient and remainder
            int quotient = number1 / number2;
            int remainder = number1 % number2;

            // Display the results
            Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}.");
        }
    }
}
