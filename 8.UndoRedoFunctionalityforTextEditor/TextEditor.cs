class TextEditor
{
    private Text head, current;
    private int maxSize = 10;
    private int size = 0;

    public TextEditor()
    {
        head = current = new Text(""); // Initial empty state
        size = 1;
    }

    public void AddState(string content)
    {
        Text newNode = new Text(content);
        newNode.Prev = current;
        current.Next = newNode;
        current = newNode;
        size++;

        // Maintain history size limit
        if (size > maxSize)
        {
            head = head.Next;
            head.Prev = null;
            size--;
        }
    }

    public void Undo()
    {
        if (current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Undo: " + current.Content);
        }
        else
        {
            Console.WriteLine("No more undo steps available.");
        }
    }

    public void Redo()
    {
        if (current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Redo: " + current.Content);
        }
        else
        {
            Console.WriteLine("No more redo steps available.");
        }
    }

    public void DisplayCurrentState()
    {
        Console.WriteLine("Current State: " + current.Content);
    }
}