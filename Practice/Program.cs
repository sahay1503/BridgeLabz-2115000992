using System;

namespace NaturalNumberSum
{
    // Main program class
    public class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number:");
            string input = Console.ReadLine();

            // Validate user input
            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a natural number greater than 0.");
                return;
            }

            // Create instances of Program1 and Program2
            Program1 recursiveProgram = new Program1();
            Program2 formulaProgram = new Program2();

            // Compute results using recursion and formula
            int recursiveResult = recursiveProgram.SumUsingRecursion(n);
            int formulaResult = formulaProgram.SumUsingFormula(n);

            // Compare and display results
            Console.WriteLine($"Sum of first {n} natural numbers using recursion: {recursiveResult}");
            Console.WriteLine($"Sum of first {n} natural numbers using formula: {formulaResult}");

            // Check if both results match
            if (recursiveResult == formulaResult)
            {
                Console.WriteLine("The results from both methods match. Computation is correct.");
            }
            else
            {
                Console.WriteLine("The results from both methods do not match. There might be an error.");
            }
        }
    }
}
