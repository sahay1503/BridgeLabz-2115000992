using System;
using System.Diagnostics;
using System.Reflection;

class MathOperations
{
    public void Add()
    {
        int sum = 0;
        for (int i = 0; i < 1000000; i++)
        {
            sum += i;
        }
    }

    public void Multiply()
    {
        int product = 1;
        for (int i = 1; i < 1000; i++)
        {
            product *= i;
        }
    }
}

class ReflectionMethodTimingExample
{
    static void MeasureExecutionTime(object obj, string methodName)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);

        if (method != null)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            method.Invoke(obj, null);
            stopwatch.Stop();

            Console.WriteLine($"Execution Time of {methodName}: {stopwatch.ElapsedMilliseconds} ms");
        }
        else
        {
            Console.WriteLine($"Method '{methodName}' not found!");
        }
    }

    static void Main()
    {
        MathOperations mathOperations = new MathOperations();

        MeasureExecutionTime(mathOperations, "Add");
        MeasureExecutionTime(mathOperations, "Multiply");
    }
}
