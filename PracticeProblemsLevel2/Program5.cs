using System;
class Program5
{
    public string ReverseNumber(int number)
    {
        int reversed = 0;
        while (number != 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }

        return $"Reversed number: {reversed}";
    }
}
