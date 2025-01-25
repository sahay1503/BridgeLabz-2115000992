using System;
// Class to find factors
class Program8
{
    public static string FindFactors(int number)
    {
        string factors = "";
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors += i + " ";
            }
        }
        return $"Factors of {number} are: {factors}";
    }
}
