using System;
using System.Collections.Generic;


class Program
{
    public static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int startPump = CircularTour.FindStartingPump(petrol, distance);

        if (startPump != -1)
        {
            Console.WriteLine("Start at petrol pump index: " + startPump);
        }
        else
        {
            Console.WriteLine("No possible circular tour.");
        }
    }
}
