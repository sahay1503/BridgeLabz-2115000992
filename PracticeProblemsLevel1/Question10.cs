// Question10.cs
using System;

class Question10
{
    public void CalculateWindChill()
    {
        // Taking user input for temperature and wind speed
        Console.Write("Enter the temperature in Fahrenheit: ");
        double temperature = double.Parse(Console.ReadLine());
        Console.Write("Enter the wind speed in mph: ");
        double windSpeed = double.Parse(Console.ReadLine());

        // Calculating wind chill
        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);

        // Displaying the result
        Console.WriteLine($"The wind chill temperature is {windChill:F2} degrees Fahrenheit");
    }
}
