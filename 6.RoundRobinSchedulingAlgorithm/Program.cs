using System;
class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();

        // Adding processes
        scheduler.AddProcess(1, 8, 2);
        scheduler.AddProcess(2, 4, 1);
        scheduler.AddProcess(3, 9, 3);
        scheduler.AddProcess(4, 5, 2);

        // Display initial queue
        scheduler.DisplayProcesses();

        // Running Round Robin Scheduling with Time Quantum = 3
        scheduler.RoundRobin(3);
    }
}
