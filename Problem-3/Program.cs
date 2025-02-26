using System;
using System.IO;

class CountCSVRows
{
    static void Main()
    {
        string filePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-3\\employees.csv";
        int recordCount = 0;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                bool isHeader = true;
                while (reader.ReadLine() != null)
                {
                    if (isHeader) // Skip header row
                    {
                        isHeader = false;
                        continue;
                    }
                    recordCount++;
                }
            }
            Console.WriteLine($"Total number of records (excluding header): {recordCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
