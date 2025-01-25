using System;
// Class to separate numbers into odd and even arrays
class Program7
{
    public static string SeparateOddEven(int number)
    {
        if (number <= 0)
        {
            return "Invalid input. Please enter a natural number.";
        }

        int[] evens = new int[number / 2 + 1];
        int[] odds = new int[number / 2 + 1];
        int evenIndex = 0, oddIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evens[evenIndex++] = i;
            }
            else
            {
                odds[oddIndex++] = i;
            }
        }
        return $"Odd Numbers: {string.Join(", ", odds[..oddIndex])}\nEven Numbers: {string.Join(", ", evens[..evenIndex])}";
    }
}
