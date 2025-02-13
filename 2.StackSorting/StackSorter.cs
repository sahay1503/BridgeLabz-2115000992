using System;
using System.Collections.Generic;

public class StackSorter
{
    // Function to sort the stack using recursion
    public void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            // Remove the top element
            int temp = stack.Pop();

            // Recursively sort the remaining stack
            SortStack(stack);

            // Insert the popped element back in the correct position
            InsertSorted(stack, temp);
        }
    }

    // Helper function to insert an element into a sorted stack
    private void InsertSorted(Stack<int> stack, int element)
    {
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
        }
        else
        {
            int temp = stack.Pop();
            InsertSorted(stack, element);
            stack.Push(temp);
        }
    }

    // Helper function to print the stack
    public void PrintStack(Stack<int> stack)
    {
        foreach (var item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
