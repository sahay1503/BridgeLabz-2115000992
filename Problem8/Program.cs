using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<int> GetSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> symmetricDiff = new HashSet<int>(set1);
        symmetricDiff.SymmetricExceptWith(set2);
        return symmetricDiff;
    }

    static void Main()
    {
        Console.Write("Enter elements of Set 1 (comma-separated): ");
        HashSet<int> set1 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(','), int.Parse));

        Console.Write("Enter elements of Set 2 (comma-separated): ");
        HashSet<int> set2 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(','), int.Parse));

        HashSet<int> result = GetSymmetricDifference(set1, set2);

        Console.WriteLine("\nSymmetric Difference: " + string.Join(", ", result));
    }
}
