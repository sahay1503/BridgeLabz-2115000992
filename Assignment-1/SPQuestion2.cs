using System;

class SPQuestion2
{
    static void Main()
    {
        Console.Write("Enter the length of the rectangle: ");
        double len = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double wid = Convert.ToDouble(Console.ReadLine());

        double perim = 2 * (len+ wid);

        Console.WriteLine("The perimeter of the rectangle is:"+ perim);
    }
}