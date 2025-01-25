using System;
// Class to copy 2D array to 1D array
class Program9
{
    public static string CopyTo1DArray(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int[] array = new int[rows * columns];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index++] = matrix[i, j];
            }
        }

        return $"1D Array: {string.Join(", ", array)}";
    }
}
