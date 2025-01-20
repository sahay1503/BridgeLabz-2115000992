using System;

class Question4
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double rad = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(rad, 2);

        Console.WriteLine("The area of the circle is:"+area);
    }
}