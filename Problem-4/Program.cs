using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the number of elements in the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the index to retrieve value: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Value at index {index}: {numbers[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter numeric values.");
        }
    }
}
