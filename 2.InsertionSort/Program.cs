using System;

class InsertionSortClass
{
    static void InsertionSort(int[] employeeIDs)
    {
        int n = employeeIDs.Length;
        for (int i = 1; i < n; i++)
        {
            int key = employeeIDs[i];
            int j = i - 1;
            while (j >= 0 && employeeIDs[j] > key)
            {
                employeeIDs[j + 1] = employeeIDs[j];
                j--;
            }
            employeeIDs[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int id in arr)
        {
            Console.Write(id + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // array of  employee IDs
        int[] employeeIDs = { 103, 101, 108, 105, 102, 107 };

        Console.WriteLine("Original Employee IDs:");
        PrintArray(employeeIDs);

        // Sorting using Insertion Sort
        InsertionSort(employeeIDs);

        Console.WriteLine("Sorted Employee IDs in Ascending Order:");
        PrintArray(employeeIDs);
    }
}
