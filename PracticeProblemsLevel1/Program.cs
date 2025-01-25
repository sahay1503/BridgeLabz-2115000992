using System;

class MainProgram
{
    static void Main(string[] args)
    {
        // Voting Eligibility
        Console.WriteLine("### Voting Eligibility ###");
        int[] ages = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter the age of student {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(Program1.CheckVotingEligibility(ages));
        Console.WriteLine();

        // Positive, Negative, Even, Odd
        Console.WriteLine("### Positive, Negative, Even, Odd ###");
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(Program2.ClassifyAndCompare(numbers));
        Console.WriteLine();

        // Multiplication Table
        Console.WriteLine("### Multiplication Table ###");
        Console.Write("Enter a number: ");
        int tableNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program3.GenerateTable(tableNumber));
        Console.WriteLine();

        // Array Input and Sum
        Console.WriteLine("### Array Input and Sum ###");
        Console.WriteLine(Program4.InputAndSum());
        Console.WriteLine();

        // Multiplication Table (6 to 9)
        Console.WriteLine("### Multiplication Table (6 to 9) ###");
        Console.Write("Enter a number: ");
        int rangeNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program5.GenerateRangeTable(rangeNumber));
        Console.WriteLine();

        // Mean Height of Football Players
        Console.WriteLine("### Mean Height of Football Players ###");
        double[] heights = new double[11];
        for (int i = 0; i < 11; i++)
        {
            Console.Write($"Enter the height of player {i + 1}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine(Program6.CalculateMean(heights));
        Console.WriteLine();

        // Odd and Even Arrays
        Console.WriteLine("### Odd and Even Arrays ###");
        Console.Write("Enter a number: ");
        int oddEvenNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program7.SeparateOddEven(oddEvenNumber));
        Console.WriteLine();

        // Factors of a Number
        Console.WriteLine("### Factors of a Number ###");
        Console.Write("Enter a number: ");
        int factorNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program8.FindFactors(factorNumber));
        Console.WriteLine();

        // 2D to 1D Array
        Console.WriteLine("### 2D to 1D Array ###");
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter element at position ({i + 1},{j + 1}): ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine(Program9.CopyTo1DArray(matrix));
        Console.WriteLine();

        // FizzBuzz
        Console.WriteLine("### FizzBuzz ###");
        Console.Write("Enter a number: ");
        int fizzBuzzNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Program10.GenerateFizzBuzz(fizzBuzzNumber));
        Console.WriteLine();

        Console.WriteLine("### End of Level 1 Practice Programs ###");
    }
}
