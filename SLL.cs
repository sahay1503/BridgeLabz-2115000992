using System;

class Node
{
    public int data;
    public Node next;
    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class SinglyLinkedList
{
    private Node head;

    // Add at the beginning
    public void AddAtBeginning(int data)
    {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
    }

    // Add at the end
    public void AddAtEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    // Add at a specific position
    public void AddAtPosition(int data, int position)
    {
        if (position < 1)
        {
            Console.WriteLine("Position must be >= 1");
            return;
        }
        Node newNode = new Node(data);
        if (position == 1)
        {
            newNode.next = head;
            head = newNode;
            return;
        }
        Node temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.next;
        }
        if (temp == null)
        {
            Console.WriteLine("Position out of bounds");
            return;
        }
        newNode.next = temp.next;
        temp.next = newNode;
    }

    // Delete from the beginning
    public void DeleteFromBeginning()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }
        head = head.next;
    }

    // Delete from the end
    public void DeleteFromEnd()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }
        if (head.next == null)
        {
            head = null;
            return;
        }
        Node temp = head;
        while (temp.next.next != null)
        {
            temp = temp.next;
        }
        temp.next = null;
    }

    // Delete from a specific position
    public void DeleteAtPosition(int position)
    {
        if (position < 1 || head == null)
        {
            Console.WriteLine("Invalid position or list is empty");
            return;
        }
        if (position == 1)
        {
            head = head.next;
            return;
        }
        Node temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.next;
        }
        if (temp == null || temp.next == null)
        {
            Console.WriteLine("Position out of bounds");
            return;
        }
        temp.next = temp.next.next;
    }

    // Search for a node
    public bool Search(int key)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.data == key)
                return true;
            temp = temp.next;
        }
        return false;
    }

    // Display the linked list
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        SinglyLinkedList list = new SinglyLinkedList();
        list.AddAtBeginning(10);
        list.AddAtEnd(20);
        list.AddAtEnd(30);
        list.AddAtPosition(15, 2);
        list.Display();

        list.DeleteFromBeginning();
        list.Display();

        list.DeleteFromEnd();
        list.Display();

        list.DeleteAtPosition(2);
        list.Display();

        Console.WriteLine("Search 20: " + list.Search(20));
        Console.WriteLine("Search 15: " + list.Search(15));
    }
}
