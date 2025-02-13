using System;
class Program
{
    static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks();
        while (true)
        {
            Console.WriteLine("\nQueue Operations:");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Check if Empty");
            Console.WriteLine("5. Get Size");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter value to enqueue: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    queue.enqueue(value);
                    break;
                case 2:
                    Console.WriteLine("Dequeued element is : " + queue.dequeue());
                    break;
                case 3:
                    Console.WriteLine("Front element: " + queue.Peek());
                    break;
                case 4:
                    Console.WriteLine("Is queue empty? " + queue.IsEmpty());
                    break;
                case 5:
                    Console.WriteLine("Queue size: " + queue.Size());
                    break;
                case 6:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}