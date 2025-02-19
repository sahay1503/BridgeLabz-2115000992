using System;
using System.Collections.Generic;

class ReverseQueueExample
{
    static void ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();
        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }
    }

    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 10, 20, 30 });

        Console.WriteLine("Original Queue: " + string.Join(", ", queue));
        ReverseQueue(queue);
        Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));
    }
}
