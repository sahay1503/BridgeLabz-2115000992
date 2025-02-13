using System;
using System.Collections.Generic;


class Program
{
    public static void Main()
    {
        CustomHashMap hashMap = new CustomHashMap();

        while (true)
        {
            Console.WriteLine("\n--- Custom HashMap Menu ---");
            Console.WriteLine("1. Insert Key-Value Pair");
            Console.WriteLine("2. Get Value by Key");
            Console.WriteLine("3. Remove Key");
            Console.WriteLine("4. Display HashMap");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Key: ");
                    int key1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Value: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    hashMap.Put(key1, value);
                    break;

                case 2:
                    Console.Write("Enter Key to Search: ");
                    int key2 = Convert.ToInt32(Console.ReadLine());
                    int result = hashMap.Get(key2);
                    if (result != -1)
                        Console.WriteLine($"Value: {result}");
                    else
                        Console.WriteLine("Key not found!");
                    break;

                case 3:
                    Console.Write("Enter Key to Remove: ");
                    int key3 = Convert.ToInt32(Console.ReadLine());
                    hashMap.Remove(key3);
                    break;

                case 4:
                    hashMap.Display();
                    break;

                case 5:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
