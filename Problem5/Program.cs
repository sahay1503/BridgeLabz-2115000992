using System;
using System.Collections.Generic;

class LinkedListNthFromEnd
{
    static string FindNthFromEnd(LinkedList<string> list, int n)
    {
        LinkedListNode<string> fast = list.First;
        LinkedListNode<string> slow = list.First;
        for (int i = 0; i < n; i++)
        {
            if (fast == null) return "N is larger than the list size"; // Edge case
            fast = fast.Next;
        }
        while (fast != null)
        {
            fast = fast.Next;
            slow = slow.Next;
        }

        return slow.Value; 
    }

    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>(new[] { "A", "B", "C", "D", "E" });
        int N = 2;

        Console.WriteLine($"The {N}rd element from the end is: {FindNthFromEnd(list, N)}");
    }
}
