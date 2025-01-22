using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program2
    {
        public void IntOperations()
        {
            // Take three integers as input
            Console.Write("Enter the first integer (a): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer (b): ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third integer (c): ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Perform integer operations
            int result1 = a + b * c;
            int result2 = a * b + c;
            int result3 = c + a / b;
            int result4 = a % b + c;

            // Display the results
            Console.WriteLine($"The results of Int Operations are {result1}, {result2}, {result3}, and {result4}.");
        }
    }
}
