class RoundRobinScheduler
{
    private Process head = null;
    private Process tail = null;

    public void AddProcess(int processID, int burstTime, int priority)
    {
        Process newNode = new Process(processID, burstTime, priority);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
            tail.Next = head; // Circular Link
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
            tail.Next = head;
        }
    }

    public void RemoveProcess(int processID)
    {
        if (head == null) return;

        Process current = head, prev = null;
        do
        {
            if (current.ProcessID == processID)
            {
                if (current == head && current == tail) // Only one node
                {
                    head = tail = null;
                }
                else if (current == head) // Removing head
                {
                    head = head.Next;
                    tail.Next = head;
                }
                else if (current == tail) // Removing tail
                {
                    prev.Next = head;
                    tail = prev;
                }
                else // Removing middle node
                {
                    prev.Next = current.Next;
                }
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != head);
    }

    public void RoundRobin(int timeQuantum)
    {
        if (head == null) return;

        int totalTime = 0, completedProcesses = 0;
        double totalWaitingTime = 0, totalTurnaroundTime = 0;
        Process current = head;

        Console.WriteLine("\nRound Robin Scheduling with Time Quantum: " + timeQuantum);

        while (completedProcesses < CountProcesses())
        {
            Console.WriteLine("\nProcess Queue:");
            DisplayProcesses();

            if (current.RemainingTime > 0)
            {
                int executionTime = Math.Min(current.RemainingTime, timeQuantum);
                Console.WriteLine($"Executing Process {current.ProcessID} for {executionTime} units.");
                current.RemainingTime -= executionTime;
                totalTime += executionTime;

                if (current.RemainingTime == 0)
                {
                    completedProcesses++;
                    int turnaroundTime = totalTime;
                    int waitingTime = turnaroundTime - current.BurstTime;
                    totalWaitingTime += waitingTime;
                    totalTurnaroundTime += turnaroundTime;
                    Console.WriteLine($"Process {current.ProcessID} completed. Turnaround Time: {turnaroundTime}, Waiting Time: {waitingTime}");
                    RemoveProcess(current.ProcessID);
                }
            }
            current = current.Next;
        }

        Console.WriteLine("\nAverage Waiting Time: " + (totalWaitingTime / completedProcesses));
        Console.WriteLine("Average Turnaround Time: " + (totalTurnaroundTime / completedProcesses));
    }

    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in queue.");
            return;
        }

        Process current = head;
        do
        {
            Console.WriteLine($"Process ID: {current.ProcessID}, Burst Time: {current.BurstTime}, Remaining Time: {current.RemainingTime}, Priority: {current.Priority}");
            current = current.Next;
        } while (current != head);
    }

    private int CountProcesses()
    {
        if (head == null) return 0;

        int count = 0;
        Process current = head;
        do
        {
            count++;
            current = current.Next;
        } while (current != head);

        return count;
    }
}
