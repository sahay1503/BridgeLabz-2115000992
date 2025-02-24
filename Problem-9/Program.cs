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

            Console.Write("Enter index to access: ");
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                int value = numbers[index]; 

                Console.Write("Enter divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                try
                {
                    int result = value / divisor; 
                    Console.WriteLine("Division result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter numeric values.");
        }
    }
}
