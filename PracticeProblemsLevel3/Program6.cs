using System;

// Creating class Calculator for basic arithmetic operations
class Program6
{
    public static string PerformOperation(double first, double second, string op)
    {
        // Perform arithmetic operations based on the operator
        if (op == "+")
        {
            return $"The result of {first} + {second} is {first + second}";
        }
        else if (op == "-")
        {
            return $"The result of {first} - {second} is {first - second}";
        }
        else if (op == "*")
        {
            return $"The result of {first} * {second} is {first * second}";
        }
        else if (op == "/")
        {
            if (second != 0)
            {
                return $"The result of {first} / {second} is {first / second}";
            }
            else
            {
                return "Division by zero is not allowed.";
            }
        }
        else
        {
            return "Invalid operator. Please use +, -, *, or /.";
        }
    }
}