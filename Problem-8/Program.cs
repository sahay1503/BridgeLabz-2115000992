using System;

class Program
{
    static void Method1(int num1, int num2)
    {
        int result = num1 / num2;
        Console.WriteLine($"Result: {result}");
    }

    static void Method2(int num1, int num2)
    {
        Method1(num1, num2);
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Method2(num1, num2);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Handled exception in Main: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Handled exception in Main: Invalid input! Please enter numeric values.");
        }
    }
}
