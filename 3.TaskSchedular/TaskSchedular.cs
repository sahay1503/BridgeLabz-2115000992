class TaskScheduler
{
    private Task head = null;
    private Task tail = null;
    private Task currentTask = null; // For cyclic traversal

    // Add a task at the beginning
    public void AddAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task(taskId, taskName, priority, dueDate);
        if (head == null)
        {
            head = tail = newTask;
            tail.Next = head; // Circular link
        }
        else
        {
            newTask.Next = head;
            head = newTask;
            tail.Next = head; // Maintain circular link
        }
        Console.WriteLine("Task added at the beginning.");
    }

    // Add a task at the end
    public void AddAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task(taskId, taskName, priority, dueDate);
        if (head == null)
        {
            head = tail = newTask;
            tail.Next = head;
        }
        else
        {
            tail.Next = newTask;
            tail = newTask;
            tail.Next = head; // Maintain circular link
        }
        Console.WriteLine("Task added at the end.");
    }

    // Add a task at a specific position (1-based index)
    public void AddAtPosition(int taskId, string taskName, int priority, DateTime dueDate, int position)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position.");
            return;
        }
        if (position == 1)
        {
            AddAtBeginning(taskId, taskName, priority, dueDate);
            return;
        }

        Task newTask = new Task(taskId, taskName, priority, dueDate);
        Task temp = head;
        int count = 1;

        while (temp.Next != head && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        newTask.Next = temp.Next;
        temp.Next = newTask;

        if (temp == tail) // If inserted at last position
            tail = newTask;

        Console.WriteLine($"Task added at position {position}.");
    }

    // Remove a task by Task ID
    public void RemoveByTaskID(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("Task list is empty.");
            return;
        }

        Task temp = head, prev = null;

        // If head contains the task
        if (head.TaskID == taskId)
        {
            if (head == tail) // Only one node
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                tail.Next = head;
            }
            Console.WriteLine($"Task {taskId} removed.");
            return;
        }

        // Search for the task
        do
        {
            prev = temp;
            temp = temp.Next;
            if (temp.TaskID == taskId)
            {
                prev.Next = temp.Next;
                if (temp == tail)
                    tail = prev;
                Console.WriteLine($"Task {taskId} removed.");
                return;
            }
        } while (temp != head);

        Console.WriteLine("Task not found.");
    }

    // View the current task and move to the next task in a circular manner
    public void ViewNextTask()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        if (currentTask == null)
            currentTask = head;

        Console.WriteLine($"Current Task -> ID: {currentTask.TaskID}, Name: {currentTask.TaskName}, Priority: {currentTask.Priority}, Due Date: {currentTask.DueDate}");
        currentTask = currentTask.Next; // Move to next task in circular order
    }

    // Display all tasks starting from head
    public void DisplayAllTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Task temp = head;
        Console.WriteLine("Task List:");
        do
        {
            Console.WriteLine($"ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
            temp = temp.Next;
        } while (temp != head);
    }

    // Search for a task by Priority
    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Task temp = head;
        bool found = false;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine($"Found Task -> ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No tasks found with this priority.");
    }
}
