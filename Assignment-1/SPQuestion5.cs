using System;

class SPQuestion5
{
    static void Main()
    {
        Console.Write("Enter distance in kilometers: ");
        double kms = Convert.ToDouble(Console.ReadLine());

        double miles = kms * 0.621371;

        Console.WriteLine(kms + "kilometers is equal to" + miles + "miles.");
    }
}