using System;
using System.Diagnostics;

class SortingComparison
{
    static void BubbleSort(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }

    static void MergeSort(int[] array)
    {
        if (array.Length <= 1) return;
        int middle = array.Length / 2;
        int[] leftPart = new int[middle];
        int[] rightPart = new int[array.Length - middle];

        Array.Copy(array, 0, leftPart, 0, middle);
        Array.Copy(array, middle, rightPart, 0, array.Length - middle);

        MergeSort(leftPart);
        MergeSort(rightPart);
        MergeArrays(array, leftPart, rightPart);
    }

    static void MergeArrays(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
            array[k++] = (left[i] < right[j]) ? left[i++] : right[j++];

        while (i < left.Length) array[k++] = left[i++];
        while (j < right.Length) array[k++] = right[j++];
    }

    static void QuickSort(int[] array, int start, int end)
    {
        if (start < end)
        {
            int pivotIndex = PartitionArray(array, start, end);
            QuickSort(array, start, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, end);
        }
    }

    static int PartitionArray(int[] array, int start, int end)
    {
        int pivotValue = array[end];
        int i = start - 1;

        for (int j = start; j < end; j++)
        {
            if (array[j] < pivotValue)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
        (array[i + 1], array[end]) = (array[end], array[i + 1]);
        return i + 1;
    }

    static double ComputeExecutionTime(Action<int[]> sortingFunction, int[] array)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        sortingFunction(array);
        timer.Stop();
        return (double)timer.ElapsedTicks / Stopwatch.Frequency * 1000;
    }

    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };
        Random randGen = new Random();

        Console.WriteLine("Dataset Size | Bubble Sort (ms) | Merge Sort (ms) | Quick Sort (ms)");
        Console.WriteLine("------------------------------------------------------------------");

        foreach (int size in sizes)
        {
            int[] arrayBubble, arrayMerge, arrayQuick;

            int[] baseArray = new int[size];
            for (int i = 0; i < size; i++)
                baseArray[i] = randGen.Next(0, size);

            arrayBubble = (int[])baseArray.Clone();
            arrayMerge = (int[])baseArray.Clone();
            arrayQuick = (int[])baseArray.Clone();

            double bubbleDuration = (size > 10000) ? double.PositiveInfinity : ComputeExecutionTime(BubbleSort, arrayBubble);
            double mergeDuration = ComputeExecutionTime(MergeSort, arrayMerge);
            double quickDuration = ComputeExecutionTime(arr => QuickSort(arr, 0, arr.Length - 1), arrayQuick);

            Console.WriteLine($"{size,11} | {bubbleDuration,16:F4} | {mergeDuration,15:F4} | {quickDuration,14:F4}");
        }
    }
}
