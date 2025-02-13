public class QueueUsingStacks
{
    //two stacks to implement queue
    private Stack<int> stack1;
    private Stack<int> stack2;

    public QueueUsingStacks()
    {
        //initialize both stacks
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    //queue Operation
    public void enqueue(int item)
    {
        stack1.Push(item);//push directly to stack1
    }
    //dequeue Operation
    public int dequeue()
    {
        // If stack2 is empty, transfer elements from stack1 to stack2
        if (stack2.Count == 0)
        {
            if (stack1.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            // Transfer all elements from stack1 to stack2
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());//reverse order in stack2
            }
        }
        return stack2.Pop();//pop the front element from stack 2
    }
    //Peek Operation
    public int Peek()
    {
        // Transfer elements if stack2 is empty
        if (stack2.Count == 0)
        {
            if (stack1.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        return stack2.Peek();// Return the top element of stack2
    }
    // Check if the queue is empty
    public bool IsEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }

    // Get queue size
    public int Size()
    {
        return stack1.Count + stack2.Count;
    }
}