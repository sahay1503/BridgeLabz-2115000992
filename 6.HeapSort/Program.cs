using System;

class HeapSortClass
{
    // Function to heapify a subtree rooted at index 'i'
    static void Heapify(int[] salaries, int n, int i)
    {
        int largest = i; 
        int left = 2 * i + 1; 
        int right = 2 * i + 2; 
        if (left < n && salaries[left] > salaries[largest])
        {
            largest = left;
        }
        if (right < n && salaries[right] > salaries[largest])
        {
            largest = right;
        }
        if (largest != i)
        {
            (salaries[i], salaries[largest]) = (salaries[largest], salaries[i]);
            Heapify(salaries, n, largest);
        }
    }

    // Function to perform Heap Sort
    static void HeapSort(int[] salaries)
    {
        int n = salaries.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            (salaries[0], salaries[i]) = (salaries[i], salaries[0]);
            Heapify(salaries, i, 0);
        }
    }

    // Function to print the array
    static void PrintArray(int[] arr)
    {
        foreach (int salary in arr)
        {
            Console.Write(salary + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // Array of  salary demands
        int[] salaryDemands = { 55000, 70000, 48000, 60000, 75000, 52000, 68000 };

        Console.WriteLine("Original Salary Demands:");
        PrintArray(salaryDemands);

        // Sorting using Heap Sort
        HeapSort(salaryDemands);

        Console.WriteLine("Sorted Salary Demands in Ascending Order:");
        PrintArray(salaryDemands);
    }
}
