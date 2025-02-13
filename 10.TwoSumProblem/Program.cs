using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Two Sum Problem Menu ---");
            Console.WriteLine("1. Find Two Sum");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the number of elements in the array: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] nums = new int[n];

                    Console.WriteLine("Enter array elements:");
                    for (int i = 0; i < n; i++)
                    {
                        nums[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.Write("Enter the target sum: ");
                    int target = Convert.ToInt32(Console.ReadLine());

                    int[] result = TwoSumSolver.TwoSum(nums, target);

                    if (result[0] != -1)
                    {
                        Console.WriteLine($"Indices found: {result[0]}, {result[1]}");
                    }
                    else
                    {
                        Console.WriteLine("No valid pair found.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
