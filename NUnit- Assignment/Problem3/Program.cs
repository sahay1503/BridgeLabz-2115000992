using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListManager listManager = new ListManager();
            List<int> ts = new List<int>();
            Console.WriteLine("Size before adding element in list");
            Console.WriteLine(listManager.GetSize(ts));
            listManager.AddElement(ts ,5);
            listManager.AddElement(ts ,6);
            listManager.AddElement(ts ,7);
            listManager.AddElement(ts ,8);
            Console.WriteLine("Size after adding element in list");
            Console.WriteLine(listManager.GetSize(ts));
            listManager.AddElement(ts, 9);
            Console.WriteLine("Size before removing element in list");
            Console.WriteLine(listManager.GetSize(ts));
            listManager.RemoveElement(ts ,7);
            Console.WriteLine("Size after adding element in list");
            Console.WriteLine(listManager.GetSize(ts));
        }
    }
}
