using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
        finally
        {
            Console.WriteLine("Operation completed.");
        }
    }
}
