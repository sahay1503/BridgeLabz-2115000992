using System;

class MatrixSum
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3];
        int sum = 0;

        Console.WriteLine("Enter elements for the 3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
                sum += matrix[i, j];
            }
        }

        Console.WriteLine("Matrix elements:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Sum of matrix elements: " + sum);
    }
}
