using System;

class SelectionSortClass
{
    // Function to implement Selection Sort
    static void SelectionSort(int[] scores)
    {
        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i; 

            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j; 
                }
            }
            (scores[minIndex], scores[i]) = (scores[i], scores[minIndex]);
        }
    }

    // Function to print the array
    static void PrintArray(int[] arr)
    {
        foreach (int score in arr)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // Array of exam scores
        int[] examScores = { 78, 92, 88, 67, 85, 90, 73 };

        Console.WriteLine("Original Exam Scores:");
        PrintArray(examScores);

        // Sorting using Selection Sort
        SelectionSort(examScores);

        Console.WriteLine("Sorted Exam Scores in Ascending Order:");
        PrintArray(examScores);
    }
}
