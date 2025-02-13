using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);
        stack.Push(5);

        StackSorter st = new StackSorter();

        Console.WriteLine("Original Stack:");
        st.PrintStack(stack);

        st.SortStack(stack);

        Console.WriteLine("Sorted Stack:");
        st.PrintStack(stack);
    }
}
