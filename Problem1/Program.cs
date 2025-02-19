using System;
using System.Collections.Generic;

class ReverseListCode
{
    static void ReverseList(List<int> list)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }
    static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
    {
        LinkedList<int> reversedList = new LinkedList<int>();
        foreach (int item in list)
        {
            reversedList.AddFirst(item);
        }
        return reversedList;
    }

    static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original List: " + string.Join(", ", list));
        ReverseList(list);
        Console.WriteLine("Reversed List: " + string.Join(", ", list));

        LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        Console.Write("Original LinkedList: ");
        foreach (var item in linkedList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);
        Console.Write("Reversed LinkedList: ");
        foreach (var item in reversedLinkedList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
