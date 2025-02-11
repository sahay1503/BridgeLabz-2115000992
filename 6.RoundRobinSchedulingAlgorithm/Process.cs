class Process
{
    public int ProcessID;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;
    public Process Next;

    public Process(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        RemainingTime = burstTime;
        Priority = priority;
        Next = null;
    }
}
