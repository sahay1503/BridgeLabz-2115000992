using System;

namespace NaturalNumberSum
{
    // Class for recursive method computation
    public class Program1
    {
        public int SumUsingRecursion(int n)
        {
            if (n == 1) // Base case
                return 1;
            return n + SumUsingRecursion(n - 1); // Recursive call
        }
    }
}