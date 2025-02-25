﻿using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class ReflectionDynamicMethodInvocation
{
    static void Main()
    {
        MathOperations mathOps = new MathOperations();
        Type type = typeof(MathOperations);

        Console.Write("Enter method name (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();

        // Get the method by name
        MethodInfo method = type.GetMethod(methodName);

        if (method != null)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Invoke method dynamically
            object result = method.Invoke(mathOps, new object[] { num1, num2 });

            Console.WriteLine($"Result of {methodName}: {result}");
        }
        else
        {
            Console.WriteLine("Method not found!");
        }
    }
}
