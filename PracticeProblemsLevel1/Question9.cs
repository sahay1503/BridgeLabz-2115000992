// Question9.cs
using System;

class Question9
{
    public void DivideChocolates()
    {
        // Taking user input for number of chocolates and children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Calculating chocolates per child and remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Displaying the results
        Console.WriteLine($"Each child gets {chocolatesPerChild} chocolates, and the remaining chocolates are {remainingChocolates}");
    }
}
