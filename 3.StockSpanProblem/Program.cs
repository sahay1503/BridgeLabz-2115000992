using System;
using System.Collections.Generic;


class Program
{
    public static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] spans = StockSpan.CalculateSpan(prices);

        Console.WriteLine("Stock Spans:");
        Console.WriteLine(string.Join(" ", spans));
    }
}
