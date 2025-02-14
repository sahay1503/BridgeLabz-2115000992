using System;

class QuickSortClass
{
    // Function to partition the array
    static int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[high]; // we have choose last element as pivot
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (prices[j] <= pivot)
            {
                i++;
                (prices[i], prices[j]) = (prices[j], prices[i]);
            }
        }
        (prices[i + 1], prices[high]) = (prices[high], prices[i + 1]);
        return i + 1;
    }
    static void QuickSort(int[] prices, int low, int high)
    {
        if (low < high)
        {
            // Find the partition index
            int partitionIndex = Partition(prices, low, high);

            QuickSort(prices, low, partitionIndex - 1);
            QuickSort(prices, partitionIndex + 1, high);
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
        // Array of product prices
        int[] productPrices = { 799, 299, 999, 499, 199, 699, 399 };

        Console.WriteLine("Original Product Prices:");
        PrintArray(productPrices);

        // Sorting using Quick Sort
        QuickSort(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("Sorted Product Prices in Ascending Order:");
        PrintArray(productPrices);
    }
}
