using System;
using System.IO;

class ReadCSV
{
    static void Main()
    {
        string filePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-13\\students.csv";
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }
                    string[] columns = line.Split(',');
                    Console.WriteLine($"ID: {columns[0]}, Name: {columns[1]}, Age: {columns[2]}, Marks: {columns[3]}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
