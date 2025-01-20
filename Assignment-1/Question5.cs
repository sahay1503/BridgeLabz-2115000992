using System;

class Question5
{
    static void Main()
    {
        Console.Write("Enter the radius of the cylinder: ");
        double rad = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the cylinder: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double vol = Math.PI * Math.Pow(rad, 2) * h;

	Console.WriteLine("The volume of the cylinder is:"+ vol);
    }
}