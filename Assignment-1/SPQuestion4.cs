using System;

class SPQuestion4
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third number: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        double avg = (n1 + n2 + n3) / 3;

        Console.WriteLine("The average of the three numbers is:"+ avg);
    }
}