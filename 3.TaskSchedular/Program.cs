using System;

class Program
{
    static void Main()
    {
        TaskScheduler taskScheduler = new TaskScheduler();

        while (true)
        {
            Console.WriteLine("\n--- Task Scheduler ---");
            Console.WriteLine("1. Add Task at Beginning");
            Console.WriteLine("2. Add Task at End");
            Console.WriteLine("3. Add Task at Specific Position");
            Console.WriteLine("4. Remove Task by Task ID");
            Console.WriteLine("5. View Current Task & Move to Next");
            Console.WriteLine("6. Display All Tasks");
            Console.WriteLine("7. Search Task by Priority");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Task ID: ");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    string name1 = Console.ReadLine();
                    Console.Write("Enter Priority: ");
                    int priority1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (yyyy-mm-dd): ");
                    DateTime dueDate1 = DateTime.Parse(Console.ReadLine());
                    taskScheduler.AddAtBeginning(id1, name1, priority1, dueDate1);
                    break;

                case 2:
                    Console.Write("Enter Task ID: ");
                    int id2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    string name2 = Console.ReadLine();
                    Console.Write("Enter Priority: ");
                    int priority2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (yyyy-mm-dd): ");
                    DateTime dueDate2 = DateTime.Parse(Console.ReadLine());
                    taskScheduler.AddAtEnd(id2, name2, priority2, dueDate2);
                    break;

                case 3:
                    Console.Write("Enter Task ID: ");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    string name3 = Console.ReadLine();
                    Console.Write("Enter Priority: ");
                    int priority3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (yyyy-mm-dd): ");
                    DateTime dueDate3 = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter Position: ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    taskScheduler.AddAtPosition(id3, name3, priority3, dueDate3, position);
                    break;

                case 4:
                    Console.Write("Enter Task ID to Remove: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    taskScheduler.RemoveByTaskID(removeId);
                    break;

                case 5:
                    taskScheduler.ViewNextTask();
                    break;

                case 6:
                    taskScheduler.DisplayAllTasks();
                    break;

                case 7:
                    Console.Write("Enter Priority to Search: ");
                    int searchPriority = Convert.ToInt32(Console.ReadLine());
                    taskScheduler.SearchByPriority(searchPriority);
                    break;

                case 8:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
