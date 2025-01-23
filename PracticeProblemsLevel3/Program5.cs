using System;

// Creating class DayOfWeekCalculator to determine the day of the week for a given date.
class Program5
{
    public static string GetDayOfWeek(int d, int m, int y)
    {
        // Applying the formula for the Gregorian calendar
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;

        // Mapping d0 to the day of the week
        string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        return $"The day of the week is {days[d0]}.";
    }
}