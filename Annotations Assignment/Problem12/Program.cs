using System;
using System.Collections.Generic;
using System.Reflection;

// Define the Custom Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class CacheResultAttribute : Attribute { }

//  Implement a Cache Manager
public static class CacheManager
{
    private static readonly Dictionary<string, object> _cache = new Dictionary<string, object>();

    public static object InvokeWithCache(object target, MethodInfo method, object[] args)
    {
        string cacheKey = $"{method.Name}({string.Join(",", args)})";

        if (_cache.TryGetValue(cacheKey, out object cachedValue))
        {
            Console.WriteLine($"Returning cached result for {cacheKey}");
            return cachedValue;
        }

        object result = method.Invoke(target, args);
        _cache[cacheKey] = result;

        Console.WriteLine($"Computed and cached result for {cacheKey}");
        return result;
    }
}

// Create a Sample Class with Cached Methods
public class ExpensiveCalculator
{
    [CacheResult]
    public int ComputeSquare(int number)
    {
        Console.WriteLine($"Performing heavy computation for {number}...");
        System.Threading.Thread.Sleep(1000); // Simulating expensive operation
        return number * number;
    }
}

// Use Reflection to Implement Caching at Runtime
public class Program
{
    public static void Main()
    {
        ExpensiveCalculator calculator = new ExpensiveCalculator();
        MethodInfo method = typeof(ExpensiveCalculator).GetMethod("ComputeSquare");

        // First Call (Computation Occurs)
        object result1 = CacheManager.InvokeWithCache(calculator, method, new object[] { 5 });
        Console.WriteLine("Result: " + result1);

        // Second Call (Returns Cached Result)
        object result2 = CacheManager.InvokeWithCache(calculator, method, new object[] { 5 });
        Console.WriteLine("Result: " + result2);

        // Third Call with a Different Input (Computation Occurs)
        object result3 = CacheManager.InvokeWithCache(calculator, method, new object[] { 7 });
        Console.WriteLine("Result: " + result3);
    }
}
