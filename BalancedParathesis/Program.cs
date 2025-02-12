using System;
using System.Collections.Generic;

class Program
{
    public static bool IsBalanced(string str)
    {
        // Stack to store opening brackets
        Stack<char> stack = new Stack<char>();

        // Iterate through each character in the string
        foreach (char ch in str)
        {
            // Push opening brackets onto the stack
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            // Check closing brackets
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                // If stack is empty, parentheses are unbalanced
                if (stack.Count == 0)
                {
                    return false;
                }

                // Pop the stack and check if it matches the current closing bracket
                char top = stack.Pop();
                if (!IsMatchingPair(top, ch))
                {
                    return false;
                }
            }
        }

        // After processing all characters, stack should be empty
        return stack.Count == 0;
    }

    // Helper method to check if brackets match
    private static bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }

    static void Main()
    {
        string input = "{[()]}"; // Test string
        if (IsBalanced(input))
        {
            Console.WriteLine("string is balanced");
        }
        else
        {
            Console.WriteLine("string is not balanced");
        }
    }
}

