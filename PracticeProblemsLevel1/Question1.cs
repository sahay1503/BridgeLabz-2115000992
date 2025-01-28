
using System;

class Question1
{
    public void CalculateSimpleInterest()
    {
        // Taking user input for principal, rate, and time
        Console.Write("Enter the Principal amount: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter the Rate of interest: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter the Time period in years: ");
        double time = double.Parse(Console.ReadLine());

        // Calculating simple interest
        double simpleInterest = (principal * rate * time) / 100;

        // Displaying the result
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, " +
            $"Rate of Interest {rate} and Time {time}");
    }
}
