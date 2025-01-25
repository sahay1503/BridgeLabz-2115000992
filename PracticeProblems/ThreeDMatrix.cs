using System;

class ThreeDMatrix
{
    static void Main(string[] args)
    {
        int[,,] matrix = new int[2, 2, 2];
        int value = 1;

        // Initialize the 3D matrix
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    matrix[i, j, k] = value++;
                }
            }
        }

        // Display the 3D matrix
        Console.WriteLine("3D Matrix:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(matrix[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
