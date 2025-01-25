using System;

// Class to classify numbers and compare first and last elements
class Program2
{
    public static string ClassifyAndCompare(int[] numbers)
    {
        string result = "";
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                result += $"Number {numbers[i]} is positive and {(numbers[i] % 2 == 0 ? "even" : "odd")}.\n";
            }
            else if (numbers[i] < 0)
            {
                result += $"Number {numbers[i]} is negative.\n";
            }
            else
            {
                result += $"Number {numbers[i]} is zero.\n";
            }
        }

        if (numbers[0] > numbers[^1])
        {
            result += "First number is greater than the last number.\n";
        }
        else if (numbers[0] < numbers[^1])
        {
            result += "First number is less than the last number.\n";
        }
        else
        {
            result += "First number is equal to the last number.\n";
        }

        return result;
    }
}
