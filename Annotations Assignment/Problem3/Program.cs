using System;
using System.Collections;

public class WarningSuppressionExample
{
    public static void Main()
    {
        // Suppress warnings for using non-generic collections
#pragma warning disable CS8602 // Dereference of a possibly null reference
#pragma warning disable CS8603 // Possible null reference return
#pragma warning disable CS0618 // Type or member is obsolete

        // Creating an ArrayList (non-generic collection)
        ArrayList list = new ArrayList();

        // Adding elements of different types (unsafe but allowed)
        list.Add(230);
        list.Add("HI SIDDHANT");
        list.Add(4.29);

        // Retrieving and displaying elements (requires explicit casting)
        int number = (int)list[0];
        string text = (string)list[1];
        double pi = (double)list[2];

        Console.WriteLine($"Number: {number}, Text: {text}, Pi: {pi}");

#pragma warning restore CS8602 // Re-enable the warning
#pragma warning restore CS8603
#pragma warning restore CS0618
    }
}
