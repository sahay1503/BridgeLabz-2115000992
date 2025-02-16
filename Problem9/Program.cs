using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 1, -4, 9, -2, 5 }; 

        int result = FindFirstNegative(numbers);

        if (result != int.MaxValue)
            Console.WriteLine($"First negative number found: {result}");
        else
            Console.WriteLine("No negative numbers found.");
    }

    static int FindFirstNegative(int[] arr)
    {
        foreach (int num in arr)
        {
            if (num < 0)
                return num;
        }
        return int.MaxValue; 
    }
}
