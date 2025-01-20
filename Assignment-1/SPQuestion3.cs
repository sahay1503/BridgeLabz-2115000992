using System;

class SPQuestion3
{
    static void Main()
    {
        Console.Write("Enter the base: ");
        double baseV = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exp = Convert.ToDouble(Console.ReadLine());

        double res = Math.Pow(baseV, exp);

        Console.WriteLine("{baseValue} raised to the power {exponent} is:" + res);
    }
}