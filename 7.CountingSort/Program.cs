using System;

class CountingSortClass
{
    // Function to perform Counting Sort
    static void CountingSort(int[] ages, int minAge, int maxAge)
    {
        int range = maxAge - minAge + 1;
        int[] count = new int[range]; 
        int[] output = new int[ages.Length];
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }

        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }

    // Function to print the array
    static void PrintArray(int[] arr)
    {
        foreach (int age in arr)
        {
            Console.Write(age + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // Array of  student ages
        int[] studentAges = { 12, 15, 10, 18, 14, 17, 13, 11, 16, 12, 15 };

        Console.WriteLine("Original Student Ages:");
        PrintArray(studentAges);

        // Sorting using Counting Sort
        CountingSort(studentAges, 10, 18);

        Console.WriteLine("Sorted Student Ages in Ascending Order:");
        PrintArray(studentAges);
    }
}
