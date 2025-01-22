using System;

namespace PracticeProblemsLevel2.Programs
{
    class Program10
    {
        public void DivideChocolates()
        {
            // Take the number of chocolates and children as input
            Console.Write("Enter the total number of chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

            // Calculate chocolates per child and remaining chocolates
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;

            // Display the results
            Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild}, and the number of remaining chocolates is {remainingChocolates}.");
        }
    }
}
