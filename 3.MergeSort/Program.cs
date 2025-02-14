using System;

class MergeSortClass
{
    static void Merge(int[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
        {
            leftArray[i] = prices[left + i];
        }
        for (int j = 0; j < n2; j++)
        {
            rightArray[j] = prices[mid + 1 + j];
        }
        int iIndex = 0, jIndex = 0;
        int k = left;
        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                prices[k] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                prices[k] = rightArray[jIndex];
                jIndex++;
            }
            k++;
        }
        while (iIndex < n1)
        {
            prices[k] = leftArray[iIndex];
            iIndex++;
            k++;
        }
        while (jIndex < n2)
        {
            prices[k] = rightArray[jIndex];
            jIndex++;
            k++;
        }
    }
    static void MergeSort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2; // Find mid 

            // Recursively sort first and second halves
            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);

            // Merge the sorted halves
            Merge(prices, left, mid, right);
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int price in arr)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // Array of book prices
        int[] bookPrices = { 500, 150, 200, 750, 300, 600, 400 };

        Console.WriteLine("Original Book Prices:");
        PrintArray(bookPrices);

        // Sorting using Merge Sort
        MergeSort(bookPrices, 0, bookPrices.Length - 1);

        Console.WriteLine("Sorted Book Prices in Ascending Order:");
        PrintArray(bookPrices);
    }
}
