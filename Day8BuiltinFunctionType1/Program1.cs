using System;
public class Program1 {
    public static void DisplayTimeZones()
    {
        Console.WriteLine("Current time in different time zones:");
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;
        Console.WriteLine($"GMT: {utcTime}");
        Console.WriteLine($"IST: {utcTime.ToOffset(TimeSpan.FromHours(5.5))}");
        Console.WriteLine($"PST: {utcTime.ToOffset(TimeSpan.FromHours(-8))}");
    }
}