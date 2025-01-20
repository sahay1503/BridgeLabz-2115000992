using System;

class Question2
{
    static void Main()
    {
        Console.Write("Enter first no: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second no: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int sum = n1 + n2;

        Console.WriteLine("The sum is:"+ sum);
    }
}