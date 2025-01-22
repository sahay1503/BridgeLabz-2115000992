using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program3
    {
        public void DoubleOperations()
        {
            // Take three double values as input
            Console.Write("Enter the first double (a): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second double (b): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third double (c): ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Perform double operations
            double result1 = a + b * c;
            double result2 = a * b + c;
            double result3 = c + a / b;
            double result4 = a % b + c;

            // Display the results
            Console.WriteLine($"The results of Double Operations are {result1:F2}, {result2:F2}, {result3:F2}, and {result4:F2}.");
        }
    }
}
