using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileProcessor processor = new FileProcessor();
            Console.WriteLine("Reading The Text file");
            string fileName = "F:\\Capg- TRAINING\\C# Programmes\\feature-22Feb2025\\NUnit- Assignment\\Problem8\\file.txt";
            Console.WriteLine(processor.ReadFromFile(fileName));
            Console.WriteLine("Writing into Text File");
            string textAdded = "Birds soared, their silhouettes dancing against twilight’s embrace.";
            processor.WriteToFile(fileName, textAdded);
            Console.WriteLine("Reading The Text file after writing into it:");
            Console.WriteLine(processor.ReadFromFile(fileName));
        }
    }
}
