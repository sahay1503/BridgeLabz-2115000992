using System;

namespace Problem4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var maths = new MathOperations();
            Console.WriteLine(maths.Divide(6, 2));
            Console.WriteLine(maths.Divide(2, 0));
        }
    }
}
