using System;

class IncrementArray
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10, 15, 20, 25 };

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i]++;
        }

        Console.WriteLine("Updated array elements:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
