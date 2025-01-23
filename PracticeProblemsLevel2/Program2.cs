using System;

// Creating class to check if a given year is a Leap Year using a single if condition
class Program2
{
    // Function to check if a year is a Leap Year
    public static string IsLeapYear2(int year)
    {
        // Ensure the year is in the Gregorian calendar range
        if (year < 1582)
        {
            return "Invalid year! Leap year calculations apply only for years >= 1582.";
        }

        // Single if statement with logical operators
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return year + " is a Leap Year.";
        }
        else
        {
            return year + " is not a Leap Year.";
        }
    }
}