using System;

class SPQuestion1
{
    static void Main()
    {
        Console.Write("Enter the Principal amount: ");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of interest: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time period in years: ");
        double t = Convert.ToDouble(Console.ReadLine());

        double sI = (p * r * t) / 100;

        Console.WriteLine("The Simple Interest is: "+ sI);
    }
}