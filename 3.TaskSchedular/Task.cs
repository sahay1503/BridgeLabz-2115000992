class Task
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public Task Next;

    public Task(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}