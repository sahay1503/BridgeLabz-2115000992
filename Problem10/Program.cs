using System;
using System.Collections.Generic;

class SubsetChecker
{
    static bool IsSubset(HashSet<int> set1, HashSet<int> set2)
    {
        return set1.IsSubsetOf(set2); 
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };

        Console.WriteLine("Is set1 a subset of set2? " + IsSubset(set1, set2));
    }
}
