using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program7
    {
        public void SwapNumbers()
        {
            // Take two numbers as input
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Swap numbers using a temporary variable
            int temp = number1;
            number1 = number2;
            number2 = temp;

            // Display the swapped numbers
            Console.WriteLine($"The swapped numbers are {number1} and {number2}.");
        }
    }
}
