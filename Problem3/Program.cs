using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b) => a * b; // Private method
}

class ReflectionPrivateMethodExample
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Type type = typeof(Calculator);

        // Access private method
        MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        if (method != null)
        {
            // Invoke the private method
            int result = (int)method.Invoke(calc, new object[] { 5, 10 });
            Console.WriteLine("Multiplication Result: " + result);
        }
        else
        {
            Console.WriteLine("Method not found!");
        }
    }
}
