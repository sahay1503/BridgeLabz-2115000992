using System;
// Class to generate multiplication table for numbers 6 to 9
class Program5
{
    public static string GenerateRangeTable(int number)
    {
        string result = "";
        for (int i = 6; i <= 9; i++)
        {
            result += $"{number} * {i} = {number * i}\n";
        }
        return result;
    }
}
