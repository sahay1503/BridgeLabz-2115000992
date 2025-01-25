using System;

class Program9
{
    public string ReverseNumber(int number)
    {
        number = Math.Abs(number); // Take absolute value for reversal

        int[] digits = new int[10];
        int count = 0;

        // Extract digits and store them in an array
        while (number > 0)
        {
            digits[count] = number % 10;
            number /= 10;
            count++;
        }

        // Store reversed number as a string
        string reversedNumber = "\nReversed Number: ";
        for (int i = 0; i < count; i++)
        {
            reversedNumber += digits[i];
        }

        return reversedNumber;
    }
}