using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int iterations = 10000;
        string text = "Hello";

        Console.WriteLine("Comparing performances of String and StringBuilder Concatenation:");

        long stringTime = MeasureStringConcatenation(text, iterations);
        Console.WriteLine($"String Concatenation Time: {stringTime} ms");

        long stringBuilderTime = MeasureStringBuilderConcatenation(text, iterations);
        Console.WriteLine($"StringBuilder Concatenation Time: {stringBuilderTime} ms");

        Console.WriteLine($"StringBuilder is approximately {((double)stringTime / stringBuilderTime):F2} times faster.");
    }

    static long MeasureStringConcatenation(string text, int iterations)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        string result = "";

        for (int i = 0; i < iterations; i++)
        {
            result += text; // Inefficient due to multiple memory allocations
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    static long MeasureStringBuilderConcatenation(string text, int iterations)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < iterations; i++)
        {
            sb.Append(text); 
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
}
