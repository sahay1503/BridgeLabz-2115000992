using System;
// Creating class to check if a given year is a Leap Year
class Program1
{
    // Function to check if a year is a Leap Year
    public static string IsLeapYear(int year)
    {
        // Ensure the year is in the Gregorian calendar range
        if (year < 1582)
        {
            return "Invalid year! Leap year calculations apply only for years >= 1582.";
        }
        // Leap year logic with multiple if-else conditions
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return year + " is a Leap Year.";
                }
                else
                {
                    return year + " is not a Leap Year.";
                }
            }
            else
            {
                return year + " is a Leap Year.";
            }
        }
        else
        {
            return year + " is not a Leap Year.";
        }
    }
}