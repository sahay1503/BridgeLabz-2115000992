// Creating Class with name Program8 to count down the number from the user input value to 1 using a while loop for a rocket launch
using System;
// Class to handle countdown using a while loop
class Program8
{
    public void CountdownWithWhileLoop()
    {
        // Ask the user to input the starting number for the countdown
        Console.Write("Enter the countdown start value: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        // Using a while loop to perform the countdown
        while (counter >= 1)
        {
            Console.WriteLine(counter); // Displaying the current counter value
            counter--; // Decrementing the counter
        }

        // Indicating the end of the countdown
        Console.WriteLine("Liftoff!");
    }
}