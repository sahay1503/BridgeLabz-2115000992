using System;
class Program10
{
    public string FindDigitFrequency(int number)
    {
        int[] frequency = new int[10];

        while (number != 0)
        {
            frequency[number % 10]++;
            number /= 10;
        }

        string result = "Digit frequencies:\n";
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
                result += $"{i}: {frequency[i]}\n";
        }
        return result;
    }
}
