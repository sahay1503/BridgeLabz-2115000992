using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "inputFile.txt"; 

        try
        {
            Console.WriteLine("Enter text to write to the file (type 'exit' to stop):");

            using (StreamWriter writer = new StreamWriter(filePath, false)) // Overwrites file if it exists
            {
                string input;
                while (true)
                {
                    input = Console.ReadLine();
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                        break;

                    writer.WriteLine(input);
                }
            }

            Console.WriteLine($"User input has been written to {filePath}.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
        }
    }
}
