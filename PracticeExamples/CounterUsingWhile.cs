// Write the program to print the counter from 1 to 5 using while loop
using System;

class CounterUsingWhile
{
    public static void Main()
    {
        // Create the counter variable
        int counter = 0;

        // while loop
        while (counter < 5)
        {
            counter = counter + 1;
            Console.WriteLine("Counter = " + counter);
        }
    }
}
