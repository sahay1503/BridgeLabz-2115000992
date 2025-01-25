using System;
// Class to print multiplication table
class Program3
{
    public static string GenerateTable(int number)
    {
        string result = "";
        for (int i = 1; i <= 10; i++)
        {
            result += $"{number} * {i} = {number * i}\n";
        }
        return result;
    }
}
