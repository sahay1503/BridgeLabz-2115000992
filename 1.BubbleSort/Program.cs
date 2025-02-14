using System;

class BubbleSortClass
{
    static void BubbleSort(int[] marks)
    {
        int n = marks.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                // If current is greater than next, swap them
                if (marks[j] > marks[j + 1])
                {
                    (marks[j], marks[j + 1]) = (marks[j + 1], marks[j]);
                    swapped = true; 
                }
            }
            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int mark in arr)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // Array of student marks 
        int[] studentMarks = { 85, 72, 90, 60, 88, 76, 95, 68 };

        Console.WriteLine("Original Marks:");
        PrintArray(studentMarks);

        // Sorting the student marks using Bubble Sort
        BubbleSort(studentMarks);

        Console.WriteLine("Sorted Marks in Ascending Order:");
        PrintArray(studentMarks);
    }
}
