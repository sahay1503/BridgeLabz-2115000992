using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringUtils stringUtils = new StringUtils();
            Console.WriteLine(stringUtils.Reverse("pradeep"));
            Console.WriteLine(stringUtils.IsPalindrome("naman"));
            Console.WriteLine(stringUtils.ToUpperCase("ankur"));
        }
    }
}
