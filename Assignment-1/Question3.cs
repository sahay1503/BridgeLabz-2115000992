using System;

class Question3
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double cels = Convert.ToDouble(Console.ReadLine());

        double fnt = (cels * 9 / 5) + 32;

        Console.WriteLine(cels+" Celsius is equal to "+ fnt +" Fahrenheit.");
    }
}