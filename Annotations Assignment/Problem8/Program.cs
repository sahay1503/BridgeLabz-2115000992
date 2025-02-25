using System;
using System.Diagnostics;
using System.Reflection;

// Define the Custom Attribute
[AttributeUsage(AttributeTargets.Method)]
public class LogExecutionTimeAttribute : Attribute { }

//  Create a Helper to Measure Execution Time Using Reflection
public class ExecutionTimer
{
    public static void InvokeWithTiming(object instance, string methodName)
    {
        MethodInfo method = instance.GetType().GetMethod(methodName);
        if (method == null)
        {
            Console.WriteLine($"Method {methodName} not found.");
            return;
        }

        if (method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            method.Invoke(instance, null); // Invoke the method
            stopwatch.Stop();
            Console.WriteLine($"Execution Time for {methodName}: {stopwatch.ElapsedMilliseconds} ms");
        }
        else
        {
            method.Invoke(instance, null); // Invoke without timing
        }
    }
}

// Apply the Attribute to Methods
public class PerformanceTest
{
    [LogExecutionTime]
    public void FastMethod()
    {
        for (int i = 0; i < 1000; i++) { } // Simulate a fast operation
        Console.WriteLine("Fast method executed.");
    }

    [LogExecutionTime]
    public void SlowMethod()
    {
        System.Threading.Thread.Sleep(500); // Simulate a slow operation
        Console.WriteLine("Slow method executed.");
    }

    public void RegularMethod()
    {
        Console.WriteLine("This method does not log execution time.");
    }
}

// Test Execution Timing
public class Program
{
    public static void Main()
    {
        PerformanceTest test = new PerformanceTest();

        ExecutionTimer.InvokeWithTiming(test, "FastMethod");
        ExecutionTimer.InvokeWithTiming(test, "SlowMethod");
        ExecutionTimer.InvokeWithTiming(test, "RegularMethod"); // No logging here
    }
}
