using System;
using System.Collections.Generic;
class ListRotator
{
    static void RotateList(List<int> list, int positions)
    {
        int n = list.Count;
        positions = positions % n;
        if (positions == 0) return; 
        List<int> rotatedPart = list.GetRange(0, positions); 
        list.RemoveRange(0, positions); 
        list.AddRange(rotatedPart); 
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int rotateBy = 2;

        Console.WriteLine("Original List: " + string.Join(", ", numbers));
        RotateList(numbers, rotateBy);
        Console.WriteLine("Rotated List: " + string.Join(", ", numbers));
    }
}
