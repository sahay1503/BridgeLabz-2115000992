using System;
// Class to input numbers and calculate sum
class Program4
{
    public static string InputAndSum()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            Console.Write($"Enter number {index + 1} (0 or negative to stop): ");
            double input = Convert.ToDouble(Console.ReadLine());

            if (input <= 0 || index == 10)
                break;

            numbers[index++] = input;
        }

        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
        }

        return $"Numbers: {string.Join(", ", numbers[..index])}\nTotal Sum: {total}";
    }
}
